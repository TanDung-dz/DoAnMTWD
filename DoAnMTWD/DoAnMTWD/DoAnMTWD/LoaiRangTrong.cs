using DoAnMTWD.SQL;
using PdfSharp.Drawing;
using PdfSharp.Pdf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnMTWD
{
    public partial class frmLoaiRangTrong : Form
    {
        private readonly Model1 dbContext = new Model1();
        private readonly List<TrongRang> dataList;
        private List<TrongRang> phanLoaiList;
        private List<TrongRang> chatLieuList;

        public frmLoaiRangTrong()
        {
            InitializeComponent();
            
        }

        private void frmLoaiRangTrong_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        public void ThemThongTin(string MaBN, string HoTen, DateTime NgayKham)
        {
            // Thêm thông tin vào bảng dgv_TTPXN
            dgv_TrongRangBenhNhan.Rows.Add(MaBN, HoTen, NgayKham);

            // Các bước thêm thông tin khác (nếu có)

            // Hiển thị Form 2
            this.Show();
        }
        private void LoadData()
        {
            var dataList = dbContext.TrongRangs.ToList();

            //var phanLoaiData = dataList.Select(item => item.PhanLoai).Distinct().ToList();

            phanLoaiList = dbContext.TrongRangs.Distinct().ToList();
            cbbPhanLoai.DataSource = phanLoaiList;
            cbbPhanLoai.DisplayMember = "PhanLoai";

            chatLieuList = dbContext.TrongRangs.ToList();
            cbbChatLieu.DataSource = chatLieuList;
            cbbChatLieu.DisplayMember = "ChatLieu";
            cbbChatLieu.ValueMember = "DonGia"; // Lưu Đơn Giá


        }


        private void cbbPhanLoai_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbbChatLieu_SelectedIndexChanged(object sender, EventArgs e)
        {
            int SL = (int)numericUpDown1.Value;
            TrongRang selectedCL = cbbChatLieu.SelectedItem as TrongRang;

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (cbbPhanLoai.SelectedValue != null && cbbChatLieu.SelectedValue != null)
            {
                var selectedCL = (TrongRang)cbbChatLieu.SelectedItem;
                var selectedPL = (TrongRang)cbbPhanLoai.SelectedItem;

                string MaCL = selectedCL.MaCL;
                string PhanLoai = selectedPL.PhanLoai;
                string ChatLieu = selectedCL.ChatLieu;
                int SL = (int)numericUpDown1.Value; // Số lượng sản phẩm
                decimal DonGia = (decimal)cbbChatLieu.SelectedValue;
                decimal total = DonGia * SL;


                int index = dgvLoaiRangTrong.Rows.Add();
                dgvLoaiRangTrong.Rows[index].Cells[0].Value = MaCL;
                dgvLoaiRangTrong.Rows[index].Cells[1].Value = PhanLoai;
                dgvLoaiRangTrong.Rows[index].Cells[2].Value = ChatLieu;
                dgvLoaiRangTrong.Rows[index].Cells[3].Value = SL;
                dgvLoaiRangTrong.Rows[index].Cells[4].Value = DonGia;
                dgvLoaiRangTrong.Rows[index].Cells[5].Value = total;
            }

        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            // Tạo một tài liệu PDF mới
            PdfDocument document = new PdfDocument();
            PdfPage page = document.AddPage();
            XGraphics gfx = XGraphics.FromPdfPage(page);
            XFont font = new XFont("Arial", 12); //Định dạng cho nội dung

            int yPosition = 100; // Điểm bắt đầu vẽ nội dung
            string[] lines =
            {
                "HÓA ĐƠN TRỒNG RĂNG",

            };

            foreach (string line in lines)
            {

                gfx.DrawString(line, font, XBrushes.Black, new XRect(100, yPosition, page.Width, page.Height), XStringFormats.TopCenter);
                yPosition += 20;
            }


            gfx.DrawLine(new XPen(XColors.Black, 1), 100, yPosition, page.Width - 100, yPosition);
            yPosition += 20; // Dịch chuyển xuống để bắt đầu vẽ dòng đầu tiên từ DataGridView
            foreach (DataGridViewRow row in dgv_TrongRangBenhNhan.Rows)
            {
                if (!row.IsNewRow) // Đảm bảo không thêm dòng trống vào hóa đơn
                {
                    string MaBN = row.Cells[0].Value.ToString();
                    string HoTen = row.Cells[1].Value.ToString();
                    DateTime NgayKham = (DateTime)row.Cells[2].Value;


                    gfx.DrawString($"Mã Bệnh nhân: {MaBN}", font, XBrushes.Black, new XRect(100, yPosition, page.Width, page.Height), XStringFormats.TopLeft);
                    gfx.DrawString($"Tên Bệnh nhân: {HoTen}", font, XBrushes.Black, new XRect(100, yPosition + 20, page.Width, page.Height), XStringFormats.TopLeft);
                    gfx.DrawString($"Ngày Khám: {NgayKham.ToString("dd/MM/yyyy")}", font, XBrushes.Black, new XRect(100, yPosition + 40, page.Width, page.Height), XStringFormats.TopLeft);

                    // Vẽ đường kẻ ngăn cách giữa các Dụng cụ vật tư
                    gfx.DrawLine(new XPen(XColors.Black, 1), 100, yPosition + 140, page.Width - 100, yPosition + 140);
                    yPosition += 160; // Dịch chuyển lên cho dụng cụ vật tự tiếp theo
                }
            }
            foreach (DataGridViewRow row in dgvLoaiRangTrong.Rows)
            {
                if (!row.IsNewRow) // Đảm bảo không thêm dòng trống vào hóa đơn
                {
                    string MaCL = row.Cells[0].Value.ToString();
                    string PhanLoai = row.Cells[1].Value.ToString();
                    string ChatLieu = row.Cells[2].Value.ToString();
                    int SL = Convert.ToInt32(row.Cells[3].Value);
                    decimal DonGia = Convert.ToDecimal(row.Cells[4].Value);
                    decimal total = Convert.ToDecimal(row.Cells[5].Value);

                    gfx.DrawString($"Mã Chất liệu: {MaCL}", font, XBrushes.Black, new XRect(100, yPosition, page.Width, page.Height), XStringFormats.TopLeft);
                    gfx.DrawString($"Phân Loại: {PhanLoai}", font, XBrushes.Black, new XRect(100, yPosition + 20, page.Width, page.Height), XStringFormats.TopLeft);
                    gfx.DrawString($"Chất Liệu: {ChatLieu}", font, XBrushes.Black, new XRect(100, yPosition + 40, page.Width, page.Height), XStringFormats.TopLeft);
                    gfx.DrawString($"Số lượng: {SL}", font, XBrushes.Black, new XRect(100, yPosition + 80, page.Width, page.Height), XStringFormats.TopLeft);
                    gfx.DrawString($"Đơn giá: {DonGia:C}", font, XBrushes.Black, new XRect(100, yPosition + 100, page.Width, page.Height), XStringFormats.TopLeft);
                    gfx.DrawString($"Tổng cộng: {total:C}", font, XBrushes.Black, new XRect(100, yPosition + 120, page.Width, page.Height), XStringFormats.TopLeft);

                    // Vẽ đường kẻ ngăn cách giữa các Dụng cụ vật tư
                    gfx.DrawLine(new XPen(XColors.Black, 1), 100, yPosition + 140, page.Width - 100, yPosition + 140);
                    yPosition += 160; // Dịch chuyển lên cho dụng cụ vật tự tiếp theo
                }
            }

            string fileName = "HoaDon.pdf";
            document.Save(fileName);
            Process.Start(fileName);
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem có hàng nào được chọn không
            if (dgvLoaiRangTrong.SelectedRows.Count > 0)
            {
                // Lấy hàng đã chọn
                DataGridViewRow selectedRow = dgvLoaiRangTrong.SelectedRows[0];

                // Lấy vị trí (index) của hàng đã chọn
                int rowIndex = selectedRow.Index;

                // Xóa hàng đã chọn khỏi DataGridView
                dgvLoaiRangTrong.Rows.RemoveAt(rowIndex);
            }
            else
            {
                MessageBox.Show("Hãy chọn một hàng để xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}


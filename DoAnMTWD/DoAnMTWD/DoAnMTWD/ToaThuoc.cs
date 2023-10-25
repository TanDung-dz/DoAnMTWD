using DoAnMTWD.SQL;
using PdfSharp.Drawing;
using PdfSharp.Pdf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnMTWD
{
    public partial class frmToaThuoc : Form
    {
        private Model1 dbContext;
        public frmToaThuoc()
        {
            InitializeComponent();
            dbContext = new Model1();
        }

        private void ToaThuoc_Load(object sender, EventArgs e)
        {
            cbbThuoc.DataSource = dbContext.Thuocs.ToList();
            cbbThuoc.DisplayMember = "Tenthuoc"; // Hiển thị tên sản phẩm
            cbbThuoc.ValueMember = "DonGia"; // Lưu giá tiền

        }
        public void ThemThongTin(string MaBN, string HoTen, DateTime NgayKham)
        {
            // Thêm thông tin vào bảng dgv_TTPXN
            dgv_BenhNhanToaThuoc.Rows.Add(MaBN, HoTen, NgayKham);

            // Các bước thêm thông tin khác (nếu có)

            // Hiển thị Form 2
            this.Show();
        }
        private void cbbThuoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbThuoc.SelectedValue != null)
            {
                if (decimal.TryParse(cbbThuoc.SelectedValue.ToString(), out decimal DonGia))
                {

                    int SL = (int)numericUpDown1.Value;
                    DonGia = (decimal)cbbThuoc.SelectedValue;
                    decimal total = DonGia * SL;

                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (cbbThuoc.SelectedValue != null)
            {
                if (decimal.TryParse(cbbThuoc.SelectedValue.ToString(), out decimal DonGia))
                {
                    var selectedThuoc = (Thuoc)cbbThuoc.SelectedItem;

                    string MaThuoc = selectedThuoc.MaThuoc;
                    string Tenthuoc = selectedThuoc.Tenthuoc;
                    string MoTa = selectedThuoc.MoTa;
                    string DVT = selectedThuoc.DVT;
                    int SL = (int)numericUpDown1.Value; // Số lượng sản phẩm
                    DonGia = (decimal)cbbThuoc.SelectedValue;
                    decimal total = DonGia * SL;

                    // Thêm thông tin vào DataGridView

                    int index = dgvToaThuoc.Rows.Add();
                    dgvToaThuoc.Rows[index].Cells[0].Value = MaThuoc;
                    dgvToaThuoc.Rows[index].Cells[1].Value = Tenthuoc;
                    dgvToaThuoc.Rows[index].Cells[2].Value = MoTa;
                    dgvToaThuoc.Rows[index].Cells[3].Value = DVT;
                    dgvToaThuoc.Rows[index].Cells[4].Value = SL;
                    dgvToaThuoc.Rows[index].Cells[5].Value = DonGia;
                    dgvToaThuoc.Rows[index].Cells[6].Value = total;

                }
                else
                {
                    // Xử lý trường hợp không thể chuyển đổi giá trị thành kiểu decimal
                    MessageBox.Show("Giá trị không hợp lệ trong ComboBox.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                // Xử lý trường hợp cbbToaThuoc.SelectedValue là null
                MessageBox.Show("Chưa chọn thuốc trong ComboBox.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void btnInHoaDon_Click(object sender, EventArgs e)
        {
            // Tạo một tài liệu PDF mới
            PdfDocument document = new PdfDocument();
            PdfPage page = document.AddPage();
            XGraphics gfx = XGraphics.FromPdfPage(page);
            XFont font = new XFont("Arial", 10); //Định dạng cho nội dung

            int yPosition = 100; // Điểm bắt đầu vẽ nội dung
            string[] lines =
            {
                "HÓA ĐƠN KHÁM BỆNH",
               
            };

            foreach (string line in lines)
            {

                gfx.DrawString(line, font, XBrushes.Black, new XRect(100, yPosition, page.Width, page.Height), XStringFormats.TopCenter);
                yPosition += 20;
            }
            gfx.DrawLine(new XPen(XColors.Black, 1), 100, yPosition, page.Width - 100, yPosition);
            yPosition += 20; // Dịch chuyển xuống để bắt đầu vẽ dòng đầu tiên từ DataGridView
            foreach (DataGridViewRow row in dgv_BenhNhanToaThuoc.Rows)
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

            // Vẽ đường kẻ ngăn cách giữa các loại thuốc
            gfx.DrawLine(new XPen(XColors.Black, 1), 100, yPosition, page.Width - 100, yPosition);
            yPosition += 20; // Dịch chuyển xuống để bắt đầu vẽ dòng đầu tiên từ DataGridView

            foreach (DataGridViewRow row in dgvToaThuoc.Rows)
            {
                if (!row.IsNewRow) // Đảm bảo không thêm dòng trống vào hóa đơn
                {
                    string MaThuoc = row.Cells[0].Value.ToString();
                    string Tenthuoc = row.Cells[1].Value.ToString();
                    string MoTa = row.Cells[2].Value.ToString();
                    string DVT = row.Cells[3].Value.ToString();
                    int SL = Convert.ToInt32(row.Cells[4].Value);
                    decimal DonGia = Convert.ToDecimal(row.Cells[5].Value);
                    decimal total = Convert.ToDecimal(row.Cells[6].Value);

                    gfx.DrawString($"Mã thuốc: {MaThuoc}", font, XBrushes.Black, new XRect(100, yPosition, page.Width, page.Height), XStringFormats.TopLeft);
                    gfx.DrawString($"Tên thuốc: {Tenthuoc}", font, XBrushes.Black, new XRect(100, yPosition + 20, page.Width, page.Height), XStringFormats.TopLeft);
                    gfx.DrawString($"Mô tả: {MoTa}", font, XBrushes.Black, new XRect(100, yPosition + 40, page.Width, page.Height), XStringFormats.TopLeft);
                    gfx.DrawString($"Đơn vị tính: {DVT}", font, XBrushes.Black, new XRect(100, yPosition + 60, page.Width, page.Height), XStringFormats.TopLeft);
                    gfx.DrawString($"Số lượng: {SL}", font, XBrushes.Black, new XRect(100, yPosition + 80, page.Width, page.Height), XStringFormats.TopLeft);
                    gfx.DrawString($"Đơn giá: {DonGia:C}", font, XBrushes.Black, new XRect(100, yPosition + 100, page.Width, page.Height), XStringFormats.TopLeft);
                    gfx.DrawString($"Tổng cộng: {total:C}", font, XBrushes.Black, new XRect(100, yPosition + 120, page.Width, page.Height), XStringFormats.TopLeft);

                    // Vẽ đường kẻ ngăn cách giữa các loại thuốc
                    gfx.DrawLine(new XPen(XColors.Black, 1), 100, yPosition + 140, page.Width - 100, yPosition + 140);
                    yPosition += 160; // Dịch chuyển lên cho loại thuốc tiếp theo
                }
            }

            string fileName = "HoaDon.pdf";
            document.Save(fileName);
            Process.Start(fileName);

        }

        private void btnRemove_Click(object sender, EventArgs e)
        {

                // Kiểm tra xem có hàng nào được chọn không
                if (dgvToaThuoc.SelectedRows.Count > 0)
                {
                    // Lấy hàng đã chọn
                    DataGridViewRow selectedRow = dgvToaThuoc.SelectedRows[0];

                    // Lấy vị trí (index) của hàng đã chọn
                    int rowIndex = selectedRow.Index;

                    // Xóa hàng đã chọn khỏi DataGridView
                    dgvToaThuoc.Rows.RemoveAt(rowIndex);
                }
                else
                {
                    MessageBox.Show("Hãy chọn một hàng để xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
    }


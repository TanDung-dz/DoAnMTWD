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
    public partial class DichVu : Form
    {
        private Model1 dbContext;
        public DichVu()
        {
            InitializeComponent();
            dbContext = new Model1();
        }

        private void dgv_dichvu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public void ThemThongTin(string maBN, string hoten, DateTime ngaykham)
        {
            // Thêm thông tin vào bảng dgv_TTPXN
            dgv_dichvu.Rows.Add(maBN, hoten, ngaykham);

            // Các bước thêm thông tin khác (nếu có)

            // Hiển thị Form 2
            this.Show();
        }

        private void DichVu_Load(object sender, EventArgs e)
        {
            cbbDichVu.DataSource = dbContext.DieuTris.ToList();
            cbbDichVu.DisplayMember = "TenDV"; // Hiển thị tên dịch vụ
            cbbDichVu.ValueMember = "DonGia"; // Lưu giá tiền
        }

        private void cbbDichVu_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbDichVu.SelectedValue != null)
            {
                if (decimal.TryParse(cbbDichVu.SelectedValue.ToString(), out decimal DonGia))
                {

                    int SL = (int)numericUpDown1.Value;
                    DonGia = (decimal)cbbDichVu.SelectedValue;
                    decimal total = DonGia * SL;

                }
            }
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            if (cbbDichVu.SelectedValue != null)
            {
                if (decimal.TryParse(cbbDichVu.SelectedValue.ToString(), out decimal DonGia))
                {
                    var selectedDV = (DieuTri)cbbDichVu.SelectedItem;

                    string MaDV = selectedDV.MaDV;
                    string TenDV = selectedDV.TenDV;
                    int SL = (int)numericUpDown1.Value; // Số lượng sản phẩm
                    string DVT = selectedDV.DVT;
                    DonGia = (decimal)cbbDichVu.SelectedValue;
                    decimal total = DonGia * SL;

                    // Thêm thông tin vào DataGridView

                    int index = dgvDieuTri.Rows.Add();
                    dgvDieuTri.Rows[index].Cells[0].Value = MaDV;
                    dgvDieuTri.Rows[index].Cells[1].Value = TenDV;
                    dgvDieuTri.Rows[index].Cells[2].Value = SL;
                    dgvDieuTri.Rows[index].Cells[3].Value = DVT;
                    dgvDieuTri.Rows[index].Cells[4].Value = DonGia;
                    dgvDieuTri.Rows[index].Cells[5].Value = total;

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

        private void btn_IN_Click(object sender, EventArgs e)
        {
            // Tạo một tài liệu PDF mới
            PdfDocument document = new PdfDocument();
            PdfPage page = document.AddPage();
            XGraphics gfx = XGraphics.FromPdfPage(page);
            XFont font = new XFont("Arial", 12); //Định dạng cho nội dung

            int yPosition = 100; // Điểm bắt đầu vẽ nội dung
            string[] lines =
            {
                "HÓA ĐƠN DỊCH VỤ",

            };

            foreach (string line in lines)
            {

                gfx.DrawString(line, font, XBrushes.Black, new XRect(100, yPosition, page.Width, page.Height), XStringFormats.TopCenter);
                yPosition += 20;
            }

            // Vẽ đường kẻ ngăn cách giữa các Loại dụng cụ vật tư
            gfx.DrawLine(new XPen(XColors.Black, 1), 100, yPosition, page.Width - 100, yPosition);
            yPosition += 20; // Dịch chuyển xuống để bắt đầu vẽ dòng đầu tiên từ DataGridView


            foreach (DataGridViewRow row in dgv_dichvu.Rows)
            {
                if (!row.IsNewRow) // Đảm bảo không thêm dòng trống vào hóa đơn
                {
                    string maBN = row.Cells[0].Value.ToString();
                    string hoten = row.Cells[1].Value.ToString();
                    DateTime ngaykham = (DateTime)row.Cells[2].Value;


                    gfx.DrawString($"Mã Bệnh nhân: {maBN}", font, XBrushes.Black, new XRect(100, yPosition, page.Width, page.Height), XStringFormats.TopLeft);
                    gfx.DrawString($"Tên Bệnh nhân: {hoten}", font, XBrushes.Black, new XRect(100, yPosition + 20, page.Width, page.Height), XStringFormats.TopLeft);
                    gfx.DrawString($"Ngày Khám: {ngaykham.ToString("dd/MM/yyyy")}", font, XBrushes.Black, new XRect(100, yPosition + 40, page.Width, page.Height), XStringFormats.TopLeft);

                    // Vẽ đường kẻ ngăn cách giữa các Dụng cụ vật tư
                    gfx.DrawLine(new XPen(XColors.Black, 1), 100, yPosition + 140, page.Width - 100, yPosition + 140);
                    yPosition += 160; // Dịch chuyển lên cho dụng cụ vật tự tiếp theo
                }
            } 

            foreach (DataGridViewRow row in dgvDieuTri.Rows )
            {
                if (!row.IsNewRow) // Đảm bảo không thêm dòng trống vào hóa đơn
                {
                    string MaDV = row.Cells[0].Value.ToString();
                    string TenDV = row.Cells[1].Value.ToString();        
                    int SL = Convert.ToInt32(row.Cells[2].Value);
                    string DVT = row.Cells[3].Value.ToString();
                    decimal DonGia = Convert.ToDecimal(row.Cells[4].Value);
                    decimal total = Convert.ToDecimal(row.Cells[5].Value);

                    gfx.DrawString($"Mã Dịch vụ: {MaDV}", font, XBrushes.Black, new XRect(100, yPosition, page.Width, page.Height), XStringFormats.TopLeft);
                    gfx.DrawString($"Tên dịch vụ: {TenDV}", font, XBrushes.Black, new XRect(100, yPosition + 20, page.Width, page.Height), XStringFormats.TopLeft);
                    gfx.DrawString($"Đơn vị tính: {DVT}", font, XBrushes.Black, new XRect(100, yPosition + 40, page.Width, page.Height), XStringFormats.TopLeft);
                    gfx.DrawString($"Số lượng: {SL}", font, XBrushes.Black, new XRect(100, yPosition + 60, page.Width, page.Height), XStringFormats.TopLeft);
                    gfx.DrawString($"Đơn giá: {DonGia:C}", font, XBrushes.Black, new XRect(100, yPosition + 80, page.Width, page.Height), XStringFormats.TopLeft);
                    gfx.DrawString($"Tổng cộng: {total:C}", font, XBrushes.Black, new XRect(100, yPosition + 100, page.Width, page.Height), XStringFormats.TopLeft);

                    // Vẽ đường kẻ ngăn cách giữa các Dụng cụ vật tư
                    gfx.DrawLine(new XPen(XColors.Black, 1), 100, yPosition + 140, page.Width - 100, yPosition + 140);
                    yPosition += 160; // Dịch chuyển lên cho dụng cụ vật tự tiếp theo
                }
            }


            string fileName = "HoaDonDichVu.pdf";
            document.Save(fileName);
            Process.Start(fileName);
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem có hàng nào được chọn không
            if (dgvDieuTri.SelectedRows.Count > 0)
            {
                // Lấy hàng đã chọn
                DataGridViewRow selectedRow = dgvDieuTri.SelectedRows[0];

                // Lấy vị trí (index) của hàng đã chọn
                int rowIndex = selectedRow.Index;

                // Xóa hàng đã chọn khỏi DataGridView
                dgvDieuTri.Rows.RemoveAt(rowIndex);
            }
            else
            {
                MessageBox.Show("Hãy chọn một hàng để xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
    }


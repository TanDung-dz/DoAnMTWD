using PdfSharp.Drawing;
using PdfSharp.Pdf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnMTWD
{
    public partial class PhieuXquang : Form
    {
        public PhieuXquang()
        {
            InitializeComponent();
        }

        private void PhieuXquang_Load(object sender, EventArgs e)
        {

        }
        public void ThemThongTin(string maBN, string hoTen, DateTime ngayKham, string makt, string ketqua)
        {
            // Thêm thông tin vào bảng dgv_TTPXN
            dgv_xquang.Rows.Add(maBN, hoTen, ngayKham, makt, ketqua);

            // Các bước thêm thông tin khác (nếu có)

            // Hiển thị Form 2
            this.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Tạo một tài liệu PDF mới
            PdfDocument document = new PdfDocument();
            PdfPage page = document.AddPage();
            XGraphics gfx = XGraphics.FromPdfPage(page);
            XFont font = new XFont("Arial", 10); // Định dạng cho nội dung

            int yPosition = 100; // Điểm bắt đầu vẽ nội dung
            string[] lines =
            {
                "PHIẾU XÉT NGHIỆM",
            };

            foreach (string line in lines)
            {
                gfx.DrawString(line, font, XBrushes.Black, new XRect(100, yPosition, page.Width, page.Height), XStringFormats.TopLeft);
                yPosition += 20;
            }


            // Vẽ đường kẻ ngăn cách giữa các Loại dụng cụ vật tư
            gfx.DrawLine(new XPen(XColors.Black, 1), 100, yPosition, page.Width - 100, yPosition);
            yPosition += 20; // Dịch chuyển xuống để bắt đầu vẽ dòng đầu tiên từ danh sách

            // In thông tin bệnh nhân và kết quả vào tài liệu PDF
            foreach (DataGridViewRow row in dgv_xquang.Rows)
            {
                if (!row.IsNewRow) // Đảm bảo không thêm dòng trống vào hóa đơn
                {
                    string maBN = row.Cells[0].Value.ToString();
                    string hoTen = row.Cells[1].Value.ToString();
                    DateTime ngaykham = (DateTime)row.Cells[2].Value;
                    string makt = row.Cells[3].Value.ToString();
                    string ketqua = row.Cells[4].Value.ToString();



                    gfx.DrawString($"Mã bệnh nhân: {maBN}", font, XBrushes.Black, new XRect(100, yPosition, page.Width, page.Height), XStringFormats.TopLeft);

                    gfx.DrawString($"Họ và tên: {hoTen} ", font, XBrushes.Black, new XRect(100, yPosition + 20, page.Width, page.Height), XStringFormats.TopLeft);

                    gfx.DrawString($"Ngày Khám: {ngaykham.ToString("dd/MM/yyyy")}", font, XBrushes.Black, new XRect(100, yPosition + 40, page.Width, page.Height), XStringFormats.TopLeft);

                    gfx.DrawString($"Mã kết quả: {makt} ", font, XBrushes.Black, new XRect(100, yPosition + 60, page.Width, page.Height), XStringFormats.TopLeft);

                    gfx.DrawString($"Kết quả: {ketqua} ", font, XBrushes.Black, new XRect(100, yPosition + 80, page.Width, page.Height), XStringFormats.TopLeft);

                    // Vẽ đường kẻ ngăn cách giữa các Dụng cụ vật tư
                    gfx.DrawLine(new XPen(XColors.Black, 1), 100, yPosition + 140, page.Width - 100, yPosition + 140);
                    yPosition += 160; // Dịch chuyển lên cho dụng cụ vật tự tiếp theo
                }
            }

            // Lưu tài liệu PDF hoặc hiển thị nó tùy theo yêu cầu
            string pdfFileName = "PhieuXetNghiem.pdf";
            document.Save(pdfFileName);
            System.Diagnostics.Process.Start(pdfFileName); // Mở tài liệu PDF
        }
    }
 }


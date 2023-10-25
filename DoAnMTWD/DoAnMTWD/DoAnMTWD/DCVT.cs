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
    public partial class frmDCVT : Form
    {
        private Model1 dbContext;
        public frmDCVT()
        {
            InitializeComponent();
            dbContext = new Model1();
        }

        private void DCVT_Load(object sender, EventArgs e)
        {
            cbbDCVT.DataSource = dbContext.DCVTs.ToList();
            cbbDCVT.DisplayMember = "TenDC"; // Hiển thị tên sản phẩm
            cbbDCVT.ValueMember = "DonGia"; // Lưu giá tiền

        }

        private void cbbDCVT_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbDCVT.SelectedValue != null)
            {
                if (decimal.TryParse(cbbDCVT.SelectedValue.ToString(), out decimal DonGia))
                {

                    int SL = (int)numericUpDown1.Value;
                    DonGia = (decimal)cbbDCVT.SelectedValue;
                    decimal total = DonGia * SL;


                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (cbbDCVT.SelectedValue != null)
            {
                if (decimal.TryParse(cbbDCVT.SelectedValue.ToString(), out decimal DonGia))
                {

                    var selectedDCVT = (DCVT)cbbDCVT.SelectedItem;

                    string MaDC = selectedDCVT.MaDC;
                    string TenDC = selectedDCVT.TenDC;
                    string MoTa = selectedDCVT.MoTa;
                    string DVT = selectedDCVT.DVT;
                    int SL = (int)numericUpDown1.Value; // Số lượng sản phẩm
                    DonGia = (decimal)cbbDCVT.SelectedValue;
                    decimal total = DonGia * SL;

                    // Thêm thông tin vào DataGridView
                    // dgvDCVT.Rows.Add(MaDC,TenDC,MoTa,DVT,SL,DonGia, total);
                    int index = dgvDCVT.Rows.Add();
                    dgvDCVT.Rows[index].Cells[0].Value = MaDC;
                    dgvDCVT.Rows[index].Cells[1].Value = TenDC;
                    dgvDCVT.Rows[index].Cells[2].Value = MoTa;
                    dgvDCVT.Rows[index].Cells[3].Value = DVT;
                    dgvDCVT.Rows[index].Cells[4].Value = SL;
                    dgvDCVT.Rows[index].Cells[5].Value = DonGia;
                    dgvDCVT.Rows[index].Cells[6].Value = total;

                }
                else
                {
                    // Xử lý trường hợp không thể chuyển đổi giá trị thành kiểu decimal
                    MessageBox.Show("Giá trị không hợp lệ trong ComboBox.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                // Xử lý trường hợp cbbDCVT.SelectedValue là null
                MessageBox.Show("Chưa chọn sản phẩm trong ComboBox.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                "HÓA ĐƠN DỤNG CỤ-VẬT TƯ",

            };

            foreach (string line in lines)
            {

                gfx.DrawString(line, font, XBrushes.Black, new XRect(100, yPosition, page.Width, page.Height), XStringFormats.TopCenter);
                yPosition += 20;
            }

            // Vẽ đường kẻ ngăn cách giữa các Loại dụng cụ vật tư
            gfx.DrawLine(new XPen(XColors.Black, 1), 100, yPosition, page.Width - 100, yPosition);
            yPosition += 20; // Dịch chuyển xuống để bắt đầu vẽ dòng đầu tiên từ DataGridView

            foreach (DataGridViewRow row in dgvDCVT.Rows)
            {
                if (!row.IsNewRow) // Đảm bảo không thêm dòng trống vào hóa đơn
                {
                    string MaDC = row.Cells[0].Value.ToString();
                    string TenDC = row.Cells[1].Value.ToString();
                    //string MoTa = row.Cells[2].Value.ToString(); Khi In phải có giá trị thì mới In được. Hiện tại trong CSDL đang để MoTa là NULL
                    string DVT = row.Cells[3].Value.ToString();
                    int SL = Convert.ToInt32(row.Cells[4].Value);
                    decimal DonGia = Convert.ToDecimal(row.Cells[5].Value);
                    decimal total = Convert.ToDecimal(row.Cells[6].Value);

                    gfx.DrawString($"Mã dụng cụ: {MaDC}", font, XBrushes.Black, new XRect(100, yPosition, page.Width, page.Height), XStringFormats.TopLeft);
                    gfx.DrawString($"Tên dụng cụ: {TenDC}", font, XBrushes.Black, new XRect(100, yPosition + 20, page.Width, page.Height), XStringFormats.TopLeft);
                    //gfx.DrawString($"Mô tả: {MoTa}", font, XBrushes.Black, new XRect(100, yPosition + 40, page.Width, page.Height), XStringFormats.TopLeft);
                    gfx.DrawString($"Đơn vị tính: {DVT}", font, XBrushes.Black, new XRect(100, yPosition + 60, page.Width, page.Height), XStringFormats.TopLeft);
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
            if (dgvDCVT.SelectedRows.Count > 0)
            {
                // Lấy hàng đã chọn
                DataGridViewRow selectedRow = dgvDCVT.SelectedRows[0];

                // Lấy vị trí (index) của hàng đã chọn
                int rowIndex = selectedRow.Index;

                // Xóa hàng đã chọn khỏi DataGridView
                dgvDCVT.Rows.RemoveAt(rowIndex);
            }
            else
            {
                MessageBox.Show("Hãy chọn một hàng để xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}

using DoAnMTWD.SQL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using DoAnMTWD.SQL; // Thay thế bằng namespace của model dữ liệu của bạn
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Diagnostics;
using PdfSharp.Pdf;
using PdfSharp.Drawing;

namespace DoAnMTWD
{
    public partial class HomeBenhVien : Form
    {

        private Model1 dbContext = new Model1();
        private BindingList<Model1> dataInDataGridView = new BindingList<Model1>();
        Model1 context = new Model1();
        public HomeBenhVien()
        {
            InitializeComponent();

        }
        private void HomeBenhVien_Load(object sender, EventArgs e)
        {
            //var query = from item in dbContext.BenhNhans
              //          select item;

            // Gán kết quả vào DataGridView
            //dgv_ThongTinBenhNhan.DataSource = query.ToList();
            try
            {
                List<XN_XQUANG> listxnquang = context.XN_XQUANG.ToList();
                List<BenhNhan> listBenhNhan = context.BenhNhans.ToList();
                List<CanL> listCanL = context.CanLS.ToList();
                List<XN_XQUANG> xN_XQUANGs = context.XN_XQUANG.ToList();       
                FillXN_QUANGCombobox(xN_XQUANGs);
                FillQUANGCombobox(xN_XQUANGs);
                FillCDCombobox(listCanL);
                BindGrid(listBenhNhan);
                BinKb(listBenhNhan);             
                BinXN(listBenhNhan);
                binTK(listBenhNhan);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

      

        private void FillCDCombobox(CanL canL)
        {
            throw new NotImplementedException();
        }

        private int GetSeclectedRow(string MBN)
        {
            for (int i = 0; i < dgv_ThongTinBenhNhan.Rows.Count; i++)
            {
                if (dgv_ThongTinBenhNhan.Rows[i].Cells[0].Value != null)
                {
                    if (dgv_ThongTinBenhNhan.Rows[i].Cells[0].Value.ToString() == MBN)
                    {
                        return i;
                    }
                }
            }
            return -1;
        }

        //---------------------------------------------------------Hien thong tin co trong datagridview -------------------------------------------------
        private void BindGrid(List<BenhNhan> BenhNhan)
        {
            dgv_ThongTinBenhNhan.Rows.Clear();
            foreach (var item in BenhNhan)
            {
                int index = dgv_ThongTinBenhNhan.Rows.Add();
                dgv_ThongTinBenhNhan.Rows[index].Cells[0].Value = item.MaBN;
                dgv_ThongTinBenhNhan.Rows[index].Cells[1].Value = item.HoTen;
                dgv_ThongTinBenhNhan.Rows[index].Cells[2].Value = item.NamSinh;
                dgv_ThongTinBenhNhan.Rows[index].Cells[3].Value = item.GioiTinh;
                if (item.GioiTinh == "Nam")
                {
                    rdb_Nam.Checked = true;
                    rdb_Nu.Checked = false;
                }
                else if (item.GioiTinh == "Nữ")
                {
                    rdb_Nam.Checked = false;
                    rdb_Nu.Checked = true;
                }
                dgv_ThongTinBenhNhan.Rows[index].Cells[4].Value = item.DiaChi;
                dgv_ThongTinBenhNhan.Rows[index].Cells[5].Value = item.SDT;
                dgv_ThongTinBenhNhan.Rows[index].Cells[6].Value = item.NgayKham;
                dgv_ThongTinBenhNhan.Rows[index].Cells[7].Value = item.LiDoKham;
               // dgv_ThongTinBenhNhan.Rows[index].Cells[8].Value = item.MaKT;
            }
        }
        private void BinKb(List<BenhNhan> BenhNhan)
        {
            dgv_KhamBenh.Rows.Clear();
            foreach (var item in BenhNhan)
            {
                int index = dgv_KhamBenh.Rows.Add();
                dgv_KhamBenh.Rows[index].Cells[0].Value = item.MaBN;
                dgv_KhamBenh.Rows[index].Cells[1].Value = item.HoTen;
                dgv_KhamBenh.Rows[index].Cells[2].Value = item.NamSinh;
                dgv_KhamBenh.Rows[index].Cells[3].Value = item.GioiTinh;
                if (item.GioiTinh == "Nam")
                {
                    rdb_Nam.Checked = true;
                    rdb_Nu.Checked = false;
                }
                else if (item.GioiTinh == "Nữ")
                {
                    rdb_Nam.Checked = false;
                    rdb_Nu.Checked = true;
                }
                dgv_KhamBenh.Rows[index].Cells[4].Value = item.DiaChi;
                dgv_KhamBenh.Rows[index].Cells[5].Value = item.SDT;
                dgv_KhamBenh.Rows[index].Cells[6].Value = item.NgayKham;
                dgv_KhamBenh.Rows[index].Cells[7].Value = item.LiDoKham;
                //dgv_KhamBenh.Rows[index].Cells[8].Value = item.MaKT;
            }
        }
       
        private void BinXN(List<BenhNhan> BenhNhan)
        {
            dgv_Xn.Rows.Clear();
            foreach (var item in BenhNhan)
            {
                int index = dgv_Xn.Rows.Add();
                dgv_Xn.Rows[index].Cells[0].Value = item.MaBN;
                dgv_Xn.Rows[index].Cells[1].Value = item.HoTen;
                dgv_Xn.Rows[index].Cells[2].Value = item.NamSinh;
                dgv_Xn.Rows[index].Cells[3].Value = item.GioiTinh;
                if (item.GioiTinh == "Nam")
                {
                    rdb_Nam.Checked = true;
                    rdb_Nu.Checked = false;
                }
                else if (item.GioiTinh == "Nữ")
                {
                    rdb_Nam.Checked = false;
                    rdb_Nu.Checked = true;
                }
                dgv_Xn.Rows[index].Cells[4].Value = item.DiaChi;
                dgv_Xn.Rows[index].Cells[5].Value = item.SDT;
                dgv_Xn.Rows[index].Cells[6].Value = item.NgayKham;
                dgv_Xn.Rows[index].Cells[7].Value = item.LiDoKham;
              //  dgv_Xn.Rows[index].Cells[8].Value = item.MaKT;
            }
        }
        private void binTK(List<BenhNhan> BenhNhan)
        {
            dgv_TK.Rows.Clear();
            foreach (var item in BenhNhan)
            {
                int index = dgv_TK.Rows.Add();
                dgv_TK.Rows[index].Cells[0].Value = item.MaBN;
                dgv_TK.Rows[index].Cells[1].Value = item.HoTen;
                dgv_TK.Rows[index].Cells[2].Value = item.NamSinh;
                dgv_TK.Rows[index].Cells[3].Value = item.GioiTinh;
                if (item.GioiTinh == "Nam")
                {
                    rdb_Nam.Checked = true;
                    rdb_Nu.Checked = false;
                }
                else if (item.GioiTinh == "Nữ")
                {
                    rdb_Nam.Checked = false;
                    rdb_Nu.Checked = true;
                }
                dgv_TK.Rows[index].Cells[4].Value = item.DiaChi;
                dgv_TK.Rows[index].Cells[5].Value = item.SDT;
                dgv_TK.Rows[index].Cells[6].Value = item.NgayKham;
                dgv_TK.Rows[index].Cells[7].Value = item.LiDoKham;
                //dgv_TK.Rows[index].Cells[8].Value = item.MaKT;
            }
        }

        //--------------------------------------------------- check tt can kiem tra ----------------------------------------------
        private bool CheckValidate()
        {
            if (txt_MaBenhNhan.Text.Trim() == "" ||
                 txt_HoVaTen.Text.Trim() == "" ||
                 txt_NamSinh.Text.Trim() == "" ||
                 rdb_Nam.Checked == false && rdb_Nu.Checked == false ||
                 //txt_DiaChi.Text.Trim() == ""||
                  txt_SDT.Text.Trim() == "" ||
                  dtNgayKham.Value == null ||
                 rtb_LyDoDenKham.Text.Trim() == "" )                   
            {      
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin bệnh nhân!");
                if (txt_SDT.Text.Length < 10 || !txt_SDT.Text.All(char.IsDigit))
                {
                    MessageBox.Show("Vui lòng nhập đủ 10 số ", "Thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                 
                }
                
               //if(!int.TryParse(txtNamSinh.Text, out int namSinh) || namSinh <1900 || namSinh > DateTime.Now.Year)
               //{
               //    MessageBox.Show("Năm sinh không hợp lệ, Vui lòng kiểm tra lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
               //  
               //}
               //
               //
               //DateTimePicker dtNgaySinh = dtNgayKham;
               //if(dtNgaySinh.Value> DateTime.Now)
               //{
               //    MessageBox.Show("Ngày khám không hợp lệ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
               //    
               //}    
               return false;
            }        
            return true;
          
        }
        private void Refresh()
        {
            txt_MaBenhNhan.Text = "";
            txt_HoVaTen.Text = "";
            txt_NamSinh.Text = "";
            rdb_Nam.Checked = false;
            rdb_Nu.Checked = false;
            txt_DiaChi.Text = "";
             txt_SDT.Text = "";         
            dtNgayKham.Value = DateTime.Parse(dtNgayKham.Value.ToShortDateString());          
            rtb_LyDoDenKham.Text = "";
        }

        //----------------------Them moi--------------------------\\
        private void btn_Them_Click(object sender, EventArgs e)
        {
            // Store the visibility state of existing rows
            List<bool> rowVisibilityStates = new List<bool>();
            foreach (DataGridViewRow row in dgv_ThongTinBenhNhan.Rows)
            {
                rowVisibilityStates.Add(row.Visible);
            }

            foreach (DataGridViewRow row in dgv_KhamBenh.Rows)
            {
                rowVisibilityStates.Add(row.Visible);
            }
            // Create a new BenhNhan object and populate its properties with the user input
            BenhNhan newBenhNhan = new BenhNhan
            {
                MaBN=txt_MaBenhNhan.Text,                     
                HoTen = txt_HoVaTen.Text,
                NamSinh = txt_NamSinh.Text,
                GioiTinh = rdb_Nu.Checked ? "Nữ" : "Nam",
                DiaChi = txt_DiaChi.Text,
                SDT = txt_SDT.Text,
                NgayKham = dtNgayKham.Value,
                LiDoKham = rtb_LyDoDenKham.Text,
                MaKT = txt_MaCD.Text
        };        
            // Perform data validation
            if (CheckValidate())
            {
                // Hide existing rows in DataGridView
                foreach (DataGridViewRow row in dgv_ThongTinBenhNhan.Rows)
                { 
                    row.Visible = false;
                    
                }
                foreach (DataGridViewRow row in dgv_KhamBenh.Rows)
                {
                    row.Visible = false;
                }
                // Add the newBenhNhan to your Entity Framework DbContext and save changes
                context.BenhNhans.Add(newBenhNhan);
                context.SaveChanges();
                refresh();
                LoadData();
              //  Add the new record to the DataGridView
                 int newRowIndex = dgv_ThongTinBenhNhan.Rows.Add(newBenhNhan.MaBN, newBenhNhan.HoTen, newBenhNhan.NamSinh,
                    newBenhNhan.GioiTinh,newBenhNhan.DiaChi,newBenhNhan.SDT,newBenhNhan.NgayKham,
                    newBenhNhan.LiDoKham,newBenhNhan.MaKT);                   
                // Restore visibility for the newly added record
                 dgv_ThongTinBenhNhan.Rows[newRowIndex].Visible = true;
                 MessageBox.Show("Thêm mới dữ liệu thành công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                HomeBenhVien_Load(sender, e);
            }
        }

        //----------------------Xoa--------------------------\\
        private void btn_Xoa_Click(object sender, EventArgs e)
        {
                BenhNhan a = context.BenhNhans.FirstOrDefault(p => p.MaBN == txt_MaBenhNhan.Text);
                if (a != null)
                {
                    DialogResult dr;

                    a.MaBN = txt_MaBenhNhan.Text;
                    a.NgayKham = dtNgayKham.Value;             
                    a.HoTen = txt_HoVaTen.Text;
                    a.GioiTinh = rdb_Nu.Checked ? "Nữ" : "Nam";              
                    a.SDT = txt_SDT.Text;                
                    a.DiaChi = txt_DiaChi.Text;             
                    a.LiDoKham = rtb_LyDoDenKham.Text;             
                    dr = MessageBox.Show("Bạn có chắc chắn xóa ? ", "Thông báo", MessageBoxButtons.YesNo,
                        MessageBoxIcon.Information);
                    if (dr == DialogResult.Yes)
                    {
                        context.BenhNhans.Remove(a);
                        context.SaveChanges();
                        MessageBox.Show("Đã xóa thành công", "Thông báo", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                        HomeBenhVien_Load(sender, e);
                    }
                }
        }

        //----------------------Sua--------------------------\\
        private void btn_Sua_Click(object sender, EventArgs e)
        {
            if (txt_MaBenhNhan.Text == "" | txt_HoVaTen.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string spIDToUpdate = txt_MaBenhNhan.Text;
            BenhNhan existing = context.BenhNhans.FirstOrDefault(s => s.MaBN == spIDToUpdate);
            existing.HoTen = txt_HoVaTen.Text;
            existing.NgayKham = dtNgayKham.Value;
            existing.SDT = txt_SDT.Text;
            existing.MaBN = txt_MaBenhNhan.Text;
            existing.DiaChi = txt_DiaChi.Text;
            existing.GioiTinh = rdb_Nam.Checked ? "Nam" : "Nữ";
            //existing.MaKT = txt_MaCD.Text;
            context.SaveChanges();
            LoadData();
            MessageBox.Show("Cập nhật dữ liệu thành công!", "Notification", MessageBoxButtons.OK);
            refresh();
        }

        private void refresh()
        {

        }

        private void LoadData()
        {
            List<BenhNhan> BenhNhans = context.BenhNhans.ToList();
            BindGrid(BenhNhans);
        }


        //------------------------------------------------------------------------- cac danh sach list voi combobox--------------------------------------------------------------------
        private void FillXN_QUANGCombobox(List<XN_XQUANG> listxnquang)
        {
                this.cmb_xn.DataSource = listxnquang;
                this.cmb_xn.DisplayMember = "MaKT";
                this.cmb_xn.ValueMember = "LoaiKT";
        }
        private void FillQUANGCombobox(List<XN_XQUANG> listxnquang)
        {
            this.cbn_xq.DataSource = listxnquang;
            this.cbn_xq.DisplayMember = "MaKT";
            this.cbn_xq.ValueMember = "LoaiKT";
        }
        private void FillCDCombobox(List<CanL> listCanL)
        {
            this.cbn_kbxn.DataSource = listCanL;
            this.cbn_kbxn.DisplayMember = "MaCD";
            this.cbn_kbxn.ValueMember = "KetQua";
        }

        private void cmb_xn_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedValue = cmb_xn.SelectedItem.ToString(); // Lấy giá trị đã chọn từ ComboBox
            
            using (Model1 context = new Model1()) // Thay thế YourDbContext bằng tên DbContext thực tế
            {
                context.Database.Log = Console.Write;
                // Truy vấn CSDL để lấy thông tin dựa trên giá trị đã chọn
              
                XN_XQUANG selectedXN = cmb_xn.SelectedItem as XN_XQUANG;
                if (selectedXN != null)
                {
                    // Hiển thị thông tin vào TextBox
                    rtb_xnxq.Text = selectedXN.LoaiKT;
                    rtb_ketluannxq.Text = selectedXN.Ten;
                }
                else
                {
                    // Xử lý trường hợp không tìm thấy giá trị trong CSDL
                    MessageBox.Show("Không tìm thấy dữ liệu cho giá trị đã chọn.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    rtb_xnxq.Text = string.Empty; // Xóa nội dung trong rtb_xnxq
                    rtb_ketluannxq.Text = string.Empty; // Xóa nội dung trong rtb_ketluannxq
                }
            }
        }
    // CBN_SQ
        private void cbn_xq_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedValue = cbn_xq.SelectedItem.ToString(); // Lấy giá trị đã chọn từ ComboBox

            using (Model1 context = new Model1()) // Thay thế YourDbContext bằng tên DbContext thực tế
            {
                context.Database.Log = Console.Write;
                // Truy vấn CSDL để lấy thông tin dựa trên giá trị đã chọn

                XN_XQUANG selectedXN = cbn_xq.SelectedItem as XN_XQUANG;
                if (selectedXN != null)
                {
                    // Hiển thị thông tin vào TextBox
                    txt_KetQuaxq.Text = selectedXN.LoaiKT;
                    rtb_ketluanxq.Text = selectedXN.Ten;
                }
                else
                {
                    // Xử lý trường hợp không tìm thấy giá trị trong CSDL
                    MessageBox.Show("Không tìm thấy dữ liệu cho giá trị đã chọn.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txt_KetQuaxq.Text = string.Empty; // Xóa nội dung trong rtb_xnxq
                    rtb_ketluanxq.Text = string.Empty; // Xóa nội dung trong rtb_ketluannxq
                }
            }
        }
        //
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedValue = cbn_kbxn.SelectedItem.ToString(); // Lấy giá trị đã chọn từ ComboBox

            using (Model1 context = new Model1()) // Thay thế YourDbContext bằng tên DbContext thực tế
            {
                context.Database.Log = Console.Write;
                // Truy vấn CSDL để lấy thông tin dựa trên giá trị đã chọn

                CanL selectedXN = cbn_kbxn.SelectedItem as CanL;
                if (selectedXN != null) 
                {
                    // Hiển thị thông tin vào TextBox
                    rtb_ttlsXetN.Text = selectedXN.KetQua;
                    rtb_XN_KL_KB.Text = selectedXN.KetLuan;
                }
                else
                {
                    // Xử lý trường hợp không tìm thấy giá trị trong CSDL
                    MessageBox.Show("Không tìm thấy dữ liệu cho giá trị đã chọn.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    rtb_ttlsXetN.Text = string.Empty; // Xóa nội dung trong rtb_xnxq
                    rtb_XN_KL_KB.Text = string.Empty; // Xóa nội dung trong rtb_ketluannxq
                }
            }
        }

        // -----------------------chua biet lam gi voi ham nay-----------------------
        private static void UpdateDataGridView(string mabn, decimal totalCost)
    { 
        using (var context = new Model1())
        {
            // Find the BenhNhan record with the provided CMND (assuming CMND is unique)
            var benhNhan = context.BenhNhans.SingleOrDefault(bn => bn.MaBN == mabn);
    
            if (benhNhan != null)
            {
                // Update the TongTien property of the BenhNhan record          
                // Save the changes to the database
                context.SaveChanges();
            }
    
        }
    }
        //----------------------------------------------------Cac ban datagridview --------------------------------------------
        private void dgv_ThongTinBenhNhan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_ThongTinBenhNhan.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgv_ThongTinBenhNhan.SelectedRows[0];

                txt_MaBenhNhan.Text = GetCellValueAsString(selectedRow.Cells[0]);
                txt_HoVaTen.Text = GetCellValueAsString(selectedRow.Cells[1]);
                txt_NamSinh.Text = GetCellValueAsString(selectedRow.Cells[2]);

                string gioiTinh = GetCellValueAsString(selectedRow.Cells[3]);
                rdb_Nam.Checked = gioiTinh == "Nam";
                rdb_Nu.Checked = gioiTinh == "Nữ";

                txt_DiaChi.Text = GetCellValueAsString(selectedRow.Cells[4]);
                txt_SDT.Text = GetCellValueAsString(selectedRow.Cells[5]);
                dtNgayKham.Text = GetCellValueAsString(selectedRow.Cells[6]);
                rtb_LyDoDenKham.Text = GetCellValueAsString(selectedRow.Cells[7]);

                Model1 context = new Model1();
                // Bạn nên thêm xử lý lỗi ở đây trong trường hợp không tìm thấy context hoặc dữ liệu.
            }
        }

        private string GetCellValueAsString(DataGridViewCell cell)
        {
            if (cell.Value != null)
            {
                return cell.Value.ToString();
            }
            return string.Empty;
        }


        private void dgv_KhamBenh_CellClick(object sender, DataGridViewCellEventArgs e)
    {
    if (dgv_KhamBenh.SelectedRows.Count > 0)
    {
        DataGridViewRow selectedRow = dgv_KhamBenh.SelectedRows[0];

        if (selectedRow.Cells[0].Value != null)
        {
            txtMabn.Text = selectedRow.Cells[0].Value.ToString();
        }
        else
        {
            txtMabn.Text = string.Empty;
        }

        if (selectedRow.Cells[1].Value != null)
        {
            txtHoten.Text = selectedRow.Cells[1].Value.ToString();
        }
        else
        {
            txtHoten.Text = string.Empty;
        }

        if (selectedRow.Cells[2].Value != null)
        {
            txtNamSinh.Text = selectedRow.Cells[2].Value.ToString();
        }
        else
        {
            txtNamSinh.Text = string.Empty;
        }

        if (selectedRow.Cells[3].Value != null)
        {
            if (selectedRow.Cells[3].Value is string)
            {
                rdb_Nam.Checked = selectedRow.Cells[3].Value.ToString() == "Nam";
                rdb_Nu.Checked = selectedRow.Cells[3].Value.ToString() == "Nữ";
            }
            else
            {
                rdb_Nam.Checked = false;
                rdb_Nu.Checked = false;
            }
        }
        else
        {
            rdb_Nam.Checked = false;
            rdb_Nu.Checked = false;
        }

        if (selectedRow.Cells[4].Value != null)
        {
            txtDiaChi.Text = selectedRow.Cells[4].Value.ToString();
        }
        else
        {
            txtDiaChi.Text = string.Empty;
        }

        if (selectedRow.Cells[5].Value != null)
        {
            if (selectedRow.Cells[5].Value is string)
            {
                txtSDT.Text = selectedRow.Cells[5].Value.ToString();
            }
            else
            {
                txtSDT.Text = string.Empty;
            }
        }
        else
        {
            txtSDT.Text = string.Empty;
        }

        if (selectedRow.Cells[6].Value != null)
        {
                    dtpNgaykham.Text = selectedRow.Cells[6].Value.ToString();
        }
        else
        {
                    dtpNgaykham.Text = string.Empty;
        }

        if (selectedRow.Cells[7].Value != null)
        {
            rtbYCk.Text = selectedRow.Cells[7].Value.ToString();
        }
        else
        {
            rtbYCk.Text = string.Empty;
        }
    }
}

        private void dgv_Xn_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_Xn.SelectedRows.Count > 0)
            {
                if (dgv_Xn.SelectedRows[0].Cells[0].Value != null)
                {
                    txt_MBNXN.Text = dgv_Xn.SelectedRows[0].Cells[0].Value.ToString();
                }

                if (dgv_Xn.SelectedRows[0].Cells[1].Value != null)
                {
                    TXT_HoTenXN.Text = dgv_Xn.SelectedRows[0].Cells[1].Value.ToString();
                }

                if (dgv_Xn.SelectedRows[0].Cells[2].Value != null)
                {
                    txt_NamSinhxn.Text = dgv_Xn.SelectedRows[0].Cells[2].Value.ToString();
                }

                if (dgv_Xn.SelectedRows[0].Cells[3].Value != null)
                {
                    rdb_Nam.Checked = dgv_Xn.SelectedRows[0].Cells[3].Value.ToString() == "Nam";
                    rdb_Nu.Checked = dgv_Xn.SelectedRows[0].Cells[3].Value.ToString() == "Nữ";

                }
                if (dgv_Xn.SelectedRows[0].Cells[4].Value != null)
                {
                    txt_DiaChixn.Text = dgv_Xn.SelectedRows[0].Cells[4].Value.ToString();
                }

                if (dgv_Xn.SelectedRows[0].Cells[5].Value != null)
                {
                    if (dgv_Xn.SelectedRows[0].Cells[5].Value is string)
                    {
                        txt_Sdtxn.Text = dgv_Xn.SelectedRows[0].Cells[5].Value.ToString();
                    }
                    else
                    {
                        txt_Sdtxn.Text = string.Empty; // Gán TextBox thành chuỗi rỗng nếu kiểu dữ liệu không tương thích
                    }
                }
                else
                {
                    txt_Sdtxn.Text = string.Empty; // Gán TextBox thành chuỗi rỗng nếu giá trị là null
                }

                if (dgv_Xn.SelectedRows[0].Cells[6].Value != null)
                {
                    dtp_NKxn.Text = dgv_Xn.SelectedRows[0].Cells[6].Value.ToString();
                }

                if (dgv_Xn.SelectedRows[0].Cells[7].Value != null)
                {
                    rtb_xn.Text = dgv_Xn.SelectedRows[0].Cells[7].Value.ToString();
                }

                Model1 context = new Model1();
                // You should add error handling here in case the context or data is not found.
            }
        }

        private void tìmKiếmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStriptxtSearch.Focus();
        }

        private void toolStriptxtSearch_Click(object sender, EventArgs e)
        {
           
        }

        private void toolStriptxtSearch_TextChanged(object sender, EventArgs e)
        {
            string searchText = toolStriptxtSearch.Text.ToLower();

            foreach (DataGridViewRow row in dgv_ThongTinBenhNhan.Rows)
            {

                string benhnhan = row.Cells["Name"].Value.ToString().ToLower();
                if (benhnhan.Contains(searchText))
                {
                    row.Visible = true;
                }
                else
                {
                    row.Visible = false;
                }
            }
        }

   

        private void tsbtn_Xoa_Click(object sender, EventArgs e)
        {
            btn_Xoa_Click(sender, e);
        }

        private void tsbtn_Sua_Click(object sender, EventArgs e)
        {
            tsbtn_Sua_Click(sender, e);
        }
    
        List<DataGridViewRow> temporaryData = new List<DataGridViewRow>();
        private void HomeBenhVien_FormClosing(object sender, FormClosingEventArgs e)
        {
              foreach (DataGridViewRow row in dgv_ThongTinBenhNhan.Rows)
            {
                if (!row.IsNewRow) // Kiểm tra không phải hàng mới
                {
                //int rowIndex = dgv_ThongTinBenhNhan.Rows.Add(row.Cells.Cast<DataGridViewCell>().Select(cell => cell.Value).ToArray());
                }
            }

            // Xóa tất cả dữ liệu từ dataGridView1
            dgv_ThongTinBenhNhan.Rows.Clear();
        }

        //-----------------------------------------------Nut Tim Kiem ben bang thong ke--------------------------------------
        private void btn_TimKiem_Click(object sender, EventArgs e)
        {
            string searchText = txt_SdtTK.Text;

            if (!string.IsNullOrEmpty(searchText))
            {
                using (Model1 context = new Model1())
                {
                    // Search for BenhNhan records based on SDT (phone number)
                    var results = context.BenhNhans
                        .Where(bn => bn.SDT.Contains(searchText))
                        .ToList();

                    // Clear the existing data in dgv_Tk
                    dgv_TK.Rows.Clear();

                    // Populate dgv_Tk with the search results
                    foreach (var result in results)
                    {
                        int rowIndex = dgv_TK.Rows.Add(
                            result.MaBN,
                            result.HoTen,
                            result.NamSinh,
                            result.GioiTinh,
                            result.DiaChi,
                            result.SDT,
                            result.NgayKham,
                            result.LiDoKham);
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng cung cấp số điện thoại để tìm kiếm.");
            }
        }


        private void btn_DangXuat_Click(object sender, EventArgs e)
        {
              this.Close();
        }

        private void btn_TK_Click(object sender, EventArgs e)
        {
        }

        private void btn_Luu_Click(object sender, EventArgs e)
        {
            CanL newCanL = new CanL
            {
                MaCD = txt_MaCD.Text,
                KetQua = rtb_ThongTinLamSan.Text,
                KetLuan = rtb_KetLuan.Text
            };

            // Tạo một đối tượng DbContext
            using (Model1 context = new Model1()) 
            {
                // Thêm đối tượng CanL vào DbSet tương ứng
                context.CanLS.Add(newCanL);
                // Lưu thay đổi vào cơ sở dữ liệu
                context.SaveChanges();
                MessageBox.Show("Dữ liệu đã được lưu vào CSDL.");
                
            }
        }
        private void btn_KhamBenhXoa_Click(object sender, EventArgs e)
        {
            CanL a = context.CanLS.FirstOrDefault(p => p.MaCD == txt_MaCD.Text);
            if (a != null)
            {
                DialogResult dr;
                dr = MessageBox.Show("Bạn có chắc chắn xóa ? ", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (dr == DialogResult.Yes)
                {
                    context.CanLS.Remove(a); // Sử dụng Remove để xóa đối tượng CanL
                    context.SaveChanges();
                    MessageBox.Show("Đã xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    HomeBenhVien_Load(sender, e);
                }
            }

        }



        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

      
        // dang looix
        private void toolStriptb_TimkiembenhnhanXN_TextChanged(object sender, EventArgs e)
        {
            string searchText = toolStriptxtSearch.Text.ToLower();

            foreach (DataGridViewRow row in dgv_Xn.Rows)
            {
                if (row.Cells["TenBNXN"].Value != null) // Kiểm tra xem ô có giá trị không
                {
                    string benhnhan = row.Cells["TenBNXN"].Value.ToString().ToLower();
                    if (benhnhan.Contains(searchText))
                    {
                        row.Visible = true;
                    }
                    else
                    {
                        row.Visible = false;
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PhieuXquang phieuXquang = new PhieuXquang();
            phieuXquang.ShowDialog();
        }

        private void btn_Xoaphieuxq_Click(object sender, EventArgs e)
        {

        }

        private void btn_TimAnh_Click(object sender, EventArgs e)
        {

        }
    //--------------------------Them PXN trong bang cac table---------------------------------
        private void btn_ThemPhieuXN_Click(object sender, EventArgs e)
        {
            
            string maBN = txt_MBNXN.Text;
            string hoTen = TXT_HoTenXN.Text;   
            DateTime ngayKham = dtp_NKxn.Value;
            string makt = cmb_xn.Text;
            string ketqua = rtb_ketluannxq.Text;
            

            // Truyền thông tin sang Form 2
            PhieuXetNghiem phieuXetNghiem = new PhieuXetNghiem();
            phieuXetNghiem.ThemThongTin(maBN, hoTen, ngayKham, makt, ketqua);
            // Mở Form 2
            phieuXetNghiem.Show();
        }

        private void btn_XoaPXN_Click(object sender, EventArgs e)
        {

        }
        private void btn_ThemPXN_Click(object sender, EventArgs e)
        {
            string maBN = txt_MBNXN.Text;
            string hoTen = TXT_HoTenXN.Text;
            DateTime ngayKham = dtp_NKxn.Value;
            string makt = cbn_xq.Text;
            string ketqua = rtb_ketluanxq.Text;


            // Truyền thông tin sang Form 2
            PhieuXquang phieuXquang = new PhieuXquang();
            phieuXquang.ThemThongTin(maBN, hoTen, ngayKham, makt, ketqua);
            // Mở Form 2
            phieuXquang.Show();
        }
        private void xn_Click(object sender, EventArgs e)
        {

        }

        private void kb_Click(object sender, EventArgs e)
        {

        }

        private void txt_SdtTK_TextChanged(object sender, EventArgs e)
        {

        }
    // ----------------------------nut lay anh -----------------------
        private void button3_Click(object sender, EventArgs e)
        {
            String imageLocation = "";

            OpenFileDialog fileOpen = new OpenFileDialog();
            fileOpen.Title = " Chọn hình ảnh sinh viên ";
            fileOpen.Filter = "Hình ảnh (.jpg;.jpeg; *.png)| *.jpg; *.jpeg; *.png | Allfiles(.) | *.*";
            if (fileOpen.ShowDialog() == DialogResult.OK)
            {
                imageLocation = fileOpen.FileName;
                picAvatar.Image = Image.FromFile(imageLocation);
                //string pathImage = imageLocation;
            }
        }
    //------ dữ liệu anh-------


        private void toolStriptb_TimkiembenhnhanXN_Click(object sender, EventArgs e)
        {

        }

        
        private void btn_CapThuoc_Click_1(object sender, EventArgs e)
        {
            string MaBN = txtMabn.Text;
            string HoTen = txtHoten.Text;
            DateTime NgayKham = dtpNgaykham.Value;

            // Truyền thông tin sang Form 2
      
       
            frmToaThuoc frmToaThuoc = new frmToaThuoc();
            frmToaThuoc.ThemThongTin(MaBN, HoTen, NgayKham);
            frmToaThuoc.Show();
        }


        private void btn_TrongRang_Click(object sender, EventArgs e)
        {
            string MaBN = txtMabn.Text;
            string HoTen = txtHoten.Text;
            DateTime NgayKham = dtpNgaykham.Value;

            frmLoaiRangTrong frmLoaiRangTrong = new frmLoaiRangTrong();
            frmLoaiRangTrong.ThemThongTin(MaBN, HoTen, NgayKham);
            frmLoaiRangTrong.Show();
        }

        private void btnTKDCVT_Click(object sender, EventArgs e)
        {
            frmDCVT frmDCVT = new frmDCVT();
            frmDCVT.ShowDialog();
        }

  
        private void btn_DV_Click_1(object sender, EventArgs e)
        {
            string maBN = txt_MBNXN.Text;
            string hoten = TXT_HoTenXN.Text;
            DateTime ngaykham = dtp_NKxn.Value;
           
            // Truyền thông tin sang Form 2
            DichVu dichVu = new DichVu();
            dichVu.ThemThongTin(maBN, hoten, ngaykham);
            // Mở Form 2
            dichVu.Show();
        }

        private void dgv_ThongTinBenhNhan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txt_MaCD_TextChanged(object sender, EventArgs e)
        {

        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}


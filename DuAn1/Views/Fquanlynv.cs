using _1_DAL.Models;
using _2_BUS.IService;
using _2_BUS.Service;
using _2_BUS.ViewModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TheArtOfDevHtmlRenderer.Adapters;

namespace DuAn1
{
    public partial class Fquanlynv : Form
    {
        private INhanVienServices _inhanVienServices;

        private staff _nv;
        private List<ViewNhanVien> _lstviewNhanViens;
        private int _id;
        public Fquanlynv()
        {
            InitializeComponent();
            _inhanVienServices = new NhanVienServices();
            _nv = new staff();
            _lstviewNhanViens = new List<ViewNhanVien>();
            loadData();
        }
        private void loadData()
        {
            dgrid_NhanVien.Rows.Clear();
            dgrid_NhanVien.ColumnCount = 7;
            dgrid_NhanVien.Columns[0].Name = "Id";
            dgrid_NhanVien.Columns[1].Name = "RoleId";
            dgrid_NhanVien.Columns[2].Name = "Displayname";
            dgrid_NhanVien.Columns[3].Name = "Password";
            dgrid_NhanVien.Columns[4].Name = "Email";
            dgrid_NhanVien.Columns[5].Name = "Phone";
            dgrid_NhanVien.Columns[6].Name = "Status";
            _lstviewNhanViens = _inhanVienServices.GetAllViewNhanVien();
            if (txt_timkiem.Text != "")
            {
                _lstviewNhanViens = _lstviewNhanViens.Where(c => c.DisplayName.Contains(txt_timkiem.Text) || c.Phone.StartsWith(txt_timkiem.Text)).ToList();
            }
            foreach (var item in _lstviewNhanViens)
            {
                dgrid_NhanVien.Rows.Add(item.Id, item.RoleId, item.DisplayName, item.Password, item.Email, item.Phone, item.Status);
            }



        }
        public void reset()
        {
            loadData();
            txt_Ten.Text = "";
            txt_Pass.Text = "";
            txt_Email.Text = "";
            txt_Sdt.Text = "";
            rbtn_onl.Checked = false;
            rbtn_off.Checked = false;
        }
        public bool checknhap()
        {
            if (txt_Pass.Text == "" || txt_Email.Text == "" || txt_Ten.Text == "" /*|| txt_user.Text == "" */|| txt_Sdt.Text == "") return false;
            return true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var p = _inhanVienServices.GetAllViewNhanVien().FirstOrDefault(p => p.DisplayName == txt_Ten.Text);
            if (checknhap() == false)
            {
                MessageBox.Show("Không được để trống các trường", "Chú ý");

            }
            else if (p != null)
            {
                MessageBox.Show("Tên nhân viên đã tồn tại", "Chú ý");
            }
            else
            {
                OpenFileDialog op = new OpenFileDialog();
                DialogResult dialog = MessageBox.Show("Bạn có muốn thêm Nhân viên không?", "Thêm", MessageBoxButtons.YesNo);
                if (dialog == DialogResult.Yes)
                {
                    ViewNhanVien nv = new ViewNhanVien()
                    {


                        DisplayName = txt_Ten.Text,
                        Password = txt_Pass.Text,
                        Email = txt_Email.Text,
                        Phone = txt_Sdt.Text,
                        Status = rbtn_onl.Checked ? 1 : 0,

                    };
                    _inhanVienServices.addNhanVien(nv);
                    MessageBox.Show($"Thêm thành công");
                    reset();
                }
            }
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            var p = _inhanVienServices.GetAllViewNhanVien().FirstOrDefault(c => c.DisplayName == txt_Ten.Text);
            if (p == null)
            {
                MessageBox.Show("Không tìm thấy tên nhân viên");
            }
            else
            {
                if (checknhap() == false)
                {
                    MessageBox.Show("Không được để trống các trường");
                }
                else
                {
                    OpenFileDialog op = new OpenFileDialog();
                    DialogResult dialog = MessageBox.Show("Bạn có muốn cập nhật lại không?", "Cập nhật", MessageBoxButtons.YesNo);
                    if (dialog == DialogResult.Yes)
                    {
                        ViewNhanVien nv = new ViewNhanVien()
                        {
                            Id = _id,
                            DisplayName = txt_Ten.Text,
                            Password = txt_Pass.Text,
                            Email = txt_Email.Text,
                            Phone = txt_Sdt.Text,
                            Status = rbtn_onl.Checked ? 1 : 0,

                        };
                        _inhanVienServices.updateNhanVien(nv);
                        MessageBox.Show("Sửa thành công");
                        reset();
                    }
                }
            }
        }

        private void dgrid_NhanVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow r = dgrid_NhanVien.Rows[e.RowIndex];
                _nv = _inhanVienServices.getAllNhanVien().FirstOrDefault(c => c.Id == _id);
                _id = int.Parse(dgrid_NhanVien.Rows[e.RowIndex].Cells[0].Value.ToString());
                txt_Ten.Text = _nv.DisplayName;
                txt_Pass.Text = _nv.Password;
                txt_Email.Text = _nv.Email;
                txt_Sdt.Text = _nv.Phone;


            }
            if (_nv.Status == 1)
            {
                rbtn_onl.Checked = true;
            }
            else
            {
                rbtn_off.Checked = true;
            }
        }
    }
}

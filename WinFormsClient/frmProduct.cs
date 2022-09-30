using Grpc.Net.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsClient
{
    public partial class frmProduct : Form
    {
        public frmProduct()
        {
            InitializeComponent();
        }
        static GrpcChannel channel = GrpcChannel.ForAddress("http://localhost:5009");
        static ProductsServices.ProductsServicesClient client = new ProductsServices.ProductsServicesClient(channel);
        static CategoriesSevices.CategoriesSevicesClient clientCategory = new CategoriesSevices.CategoriesSevicesClient(channel);

        private void frmProduct_Load(object sender, EventArgs e)
        {
            var lisProduct = client.GetAll(new ProductEmpty());
            dgvProduct.DataSource = ListProductToDataTable(lisProduct);

            var listCategory = clientCategory.GetAll(new CategoryEmpty());
            cbbCategoryId.DataSource = ToDataTable(listCategory);
            cbbCategoryId.ValueMember = "Id";
            cbbCategoryId.DisplayMember = "Name";
        }
        public DataTable ToDataTable(ListCategory listData)
        {
            DataTable dt = new DataTable();

            PropertyInfo[] Props = typeof(Category).GetProperties(BindingFlags.Public | BindingFlags.Instance);
            foreach (PropertyInfo prop in Props)
            {
                //Setting column names as Property names
                dt.Columns.Add(prop.Name);
            }

            foreach (var item in listData.Items)
            {
                var values = new object[Props.Length];
                for (int i = 0; i < Props.Length; i++)
                {
                    //inserting property values to datatable rows
                    values[i] = Props[i].GetValue(item, null);
                }
                dt.Rows.Add(values);
            }
            return dt;
        }

        public DataTable ListProductToDataTable(ListProduct listData)
        {
            DataTable dt = new DataTable();

            PropertyInfo[] Props = typeof(Product).GetProperties(BindingFlags.Public | BindingFlags.Instance);
            foreach (PropertyInfo prop in Props)
            {
                //Setting column names as Property names
                dt.Columns.Add(prop.Name);
            }

            foreach (var item in listData.Items)
            {
                var values = new object[Props.Length];
                for (int i = 0; i < Props.Length; i++)
                {
                    //inserting property values to datatable rows
                    values[i] = Props[i].GetValue(item, null);
                }
                dt.Rows.Add(values);
            }
            return dt;
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            Product product = new Product();
            product.Name = txtName.Text;
            product.TagName = txtTagName.Text;
            product.CategoryId = int.Parse((string)cbbCategoryId.SelectedValue);
            if (checkBoxActive.Checked)
            {
                product.Active = true;
            }
            else
            {
                product.Active = false;
            }
            product.CreatedDate = Google.Protobuf.WellKnownTypes.Timestamp.FromDateTime(DateTime.SpecifyKind(dateTimeCreate.Value, DateTimeKind.Utc));
            product.UpdatedDate = Google.Protobuf.WellKnownTypes.Timestamp.FromDateTime(DateTime.SpecifyKind(dateTimeUpdate.Value, DateTimeKind.Utc));

            ProductResponseResult repon = client.Create(product);
            if (repon.Result == true)
            {
                MessageBox.Show("Create Successfull", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                frmProduct_Load(sender, e);
            }
            else
            {
                MessageBox.Show("Create Not Successfull", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            ProductId productId = new ProductId();
            productId.Id = int.Parse(txtId.Text);
            if(string.IsNullOrEmpty(txtId.Text))
            {
                MessageBox.Show("Create Not Successfull", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult tl = MessageBox.Show($"Do you want to delete {txtId.Text} ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (tl == DialogResult.Yes)
                {
                    client.Delete(productId);
                }
                
                frmProduct_Load(sender, e);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Product product = new Product();
            product.Id = int.Parse(txtId.Text);
            product.Name = txtName.Text;
            product.TagName = txtTagName.Text;
            product.CategoryId = int.Parse((string)cbbCategoryId.SelectedValue);
            if (checkBoxActive.Checked)
            {
                product.Active = true;
            }
            else
            {
                product.Active = false;
            }
            product.CreatedDate = Google.Protobuf.WellKnownTypes.Timestamp.FromDateTime(DateTime.SpecifyKind(dateTimeCreate.Value, DateTimeKind.Utc));
            product.UpdatedDate = Google.Protobuf.WellKnownTypes.Timestamp.FromDateTime(DateTime.SpecifyKind(dateTimeUpdate.Value, DateTimeKind.Utc));

            ProductResponseResult responseSesult = client.Update(product);
            if (responseSesult.Result == true)
            {
                MessageBox.Show("Update Successfull", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                frmProduct_Load(sender, e);
            }
            else
            {
                MessageBox.Show("Update Not Successfull", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dgvProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            txtId.Text = dgvProduct.Rows[index].Cells["Id"].Value.ToString();
            txtName.Text = dgvProduct.Rows[index].Cells["Name"].Value.ToString();
            txtTagName.Text = dgvProduct.Rows[index].Cells["TagName"].Value.ToString();
            cbbCategoryId.Text= dgvProduct.Rows[index].Cells["CategoryId"].Value.ToString();
            if (dgvProduct.Rows[index].Cells["Active"].Value.ToString() == "True")
            {
                checkBoxActive.Checked = true;
            }
            else
            {
                checkBoxActive.Checked = false;
            }
        }
    }
}

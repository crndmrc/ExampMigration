using ExampMigration.Models;
using ExampMigration.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ExampMigration
{
    public partial class Sale : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack == true) return;

            btnRead_Click(null,null);
            EF _EF = new EF();


            ddlCustomer.DataValueField = "id";
            ddlCustomer.DataTextField = "ad";
            ddlCustomer.DataSource = _EF.Customers.ToList();
            ddlCustomer.DataBind();

            ddlProduct.DataValueField = "id";
            ddlProduct.DataTextField = "ad";
            ddlProduct.DataSource = _EF.Products.ToList();
            ddlProduct.DataBind();
        }
        protected void btnRead_Click(object sender, EventArgs e)
        {
            EF _ef = new EF();
            List<Sales> _sales = _ef.Sales.ToList();

            gvData.DataSource = _sales ;
            gvData.DataBind();
        }

        protected void btnCreate_Click(object sender, EventArgs e)
        {
            EF _ef = new EF();
            Sales _sales = new Sales();
            Product _product = new Product();
            Customer _customer = new Customer();
            _product.id = int.Parse(ddlProduct.SelectedValue.ToString());
            _customer.id = int.Parse(ddlCustomer.SelectedValue.ToString());
            _sales.product = _product;
            _sales.customer = _customer;
            _sales.quantity = int.Parse(txtQuantity.Text);
            _sales.unit = Decimal.Parse(txtUnit.Text);

            _ef.Sales.Add(_sales);
            _ef.SaveChanges();

            btnRead_Click(null, null);
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            if (lblidInfo.Text != "")
            {
                EF _ef = new EF();
                Sales _sales = _ef.Sales.Find(int.Parse(lblidInfo.Text));

                Product _product = new Product();
                Customer _customer = new Customer();
                _product.id = int.Parse(ddlProduct.SelectedValue.ToString());
                _customer.id = int.Parse(ddlCustomer.SelectedValue.ToString());
                _sales.product = _product;
                _sales.customer = _customer;
                _sales.quantity = int.Parse(txtQuantity.Text);
                _sales.unit = Decimal.Parse(txtUnit.Text);

                _ef.SaveChanges();

                btnRead_Click(null, null);

            }
            
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            if (lblidInfo.Text != "")
            {
                EF _ef = new EF();
                Sales _sales = _ef.Sales.Find(int.Parse(lblidInfo.Text));

                _ef.Sales.Remove(_sales);
                _ef.SaveChanges();

                btnRead_Click(null, null);
            }
        }

        protected void btnFind_Click(object sender, EventArgs e)
        {
            //x.product.ToString().Contains(txtSearch.Text) == true || x.customer.ToString().Contains(txtSearch.Text) == true

            EF _ef = new EF();
            List<Sales> _sales = _ef.Sales.ToList();
            IEnumerable<Sales> _selectedSale =_sales.Where(x=>x.quantity.ToString().Contains(txtSearch.Text) == true || x.unit.ToString().Contains(txtSearch.Text) == true
            || x.customer_id.ToString().Contains(txtSearch.Text) == true || x.product_id.ToString().Contains(txtSearch.Text) == true);

            gvData.DataSource = _selectedSale;
            gvData.DataBind();
        }

        protected void gvData_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (gvData.SelectedIndex >= 0)
            {
                int selectedID = int.Parse(gvData.SelectedValue.ToString());

                EF _ef = new EF();
                Sales _sales = _ef.Sales.Find(selectedID);

                lblidInfo.Text = _sales.id.ToString();
                ddlCustomer.SelectedValue = _sales.customer_id.ToString();
                ddlProduct.SelectedValue = _sales.product_id.ToString();
                txtQuantity.Text = _sales.quantity.ToString();
                txtUnit.Text = _sales.unit.ToString();
            }
        }
    }
}
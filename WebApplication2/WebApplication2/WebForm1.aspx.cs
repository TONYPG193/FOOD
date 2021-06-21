using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _WebApplication2
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void ddl_Species_SelectedIndexChanged(object sender, EventArgs e)
        {
            ddl_Food.Items.Clear();
            ddl_Num.Items.Clear();
            if (ddl_Species.SelectedValue == "飯類")
            {
                ddl_Food.Items.Add(new ListItem("炒飯", "炒飯"));
                ddl_Food.Items.Add(new ListItem("滷肉飯", "滷肉飯"));
                ddl_Food.Items.Add(new ListItem("白飯", "白飯"));
                ddl_Food.Items.Add(new ListItem("蛋包飯", "蛋包飯"));
                ddl_Num.Items.Add(new ListItem("1碗", "1碗"));
                ddl_Num.Items.Add(new ListItem("2碗", "2碗"));
                ddl_Num.Items.Add(new ListItem("3碗", "3碗"));
                ddl_Num.Items.Add(new ListItem("4碗", "4碗"));
                ddl_Num.Items.Add(new ListItem("5碗", "5碗"));
                ddl_Num.Items.Add(new ListItem("6碗", "6碗"));
                ddl_Num.Items.Add(new ListItem("7碗", "7碗"));
            }
            else if (ddl_Species.SelectedValue == "麵類")
            {
                ddl_Food.Items.Add(new ListItem("海鮮麵", "海鮮麵"));
                ddl_Food.Items.Add(new ListItem("義大利麵", "義大利麵"));
                ddl_Food.Items.Add(new ListItem("炒麵", "炒麵"));
                ddl_Food.Items.Add(new ListItem("貢丸麵", "貢丸麵"));
                ddl_Num.Items.Add(new ListItem("1碗", "1碗"));
                ddl_Num.Items.Add(new ListItem("2碗", "2碗"));
                ddl_Num.Items.Add(new ListItem("3碗", "3碗"));
                ddl_Num.Items.Add(new ListItem("4碗", "4碗"));
                ddl_Num.Items.Add(new ListItem("5碗", "5碗"));
                ddl_Num.Items.Add(new ListItem("6碗", "6碗"));
                ddl_Num.Items.Add(new ListItem("7碗", "7碗"));
            }
            else if (ddl_Species.SelectedValue == "飲料")
            {
                ddl_Food.Items.Add(new ListItem("紅茶", "紅茶"));
                ddl_Food.Items.Add(new ListItem("奶茶", "奶茶"));
                ddl_Food.Items.Add(new ListItem("雪碧", "雪碧"));
                ddl_Food.Items.Add(new ListItem("可樂", "可樂"));
                ddl_Food.Items.Add(new ListItem("白開水", "白開水"));
                ddl_Num.Items.Add(new ListItem("1杯", "1杯"));
                ddl_Num.Items.Add(new ListItem("2杯", "2杯"));
                ddl_Num.Items.Add(new ListItem("3杯", "3杯"));
                ddl_Num.Items.Add(new ListItem("4杯", "4杯"));
                ddl_Num.Items.Add(new ListItem("5杯", "5杯"));
                ddl_Num.Items.Add(new ListItem("6杯", "6杯"));
                ddl_Num.Items.Add(new ListItem("7杯", "7杯"));
            }
        }

        protected void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (RadioButton1.Checked == true)
            {
                tb_Des.Visible = false;
            }

        }
        protected void RadioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (RadioButton2.Checked == true)
            {
                tb_Des.Visible = true;
            }
        }
        protected void btn_Sub_Click(object sender, EventArgs e)
        {
            Foodlist.Text = ddl_Food.Text + "<br />";
            Foodlist.Text = Foodlist.Text + ddl_Num.Text + "<br />";
            Foodlist.Text = Foodlist.Text + tb_Name.Text + "<br />";
            Foodlist.Text = Foodlist.Text + tb_Des.Text + "<br />";
        }
    }
}
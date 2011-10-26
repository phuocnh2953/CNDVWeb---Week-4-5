using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.ServiceModel;
using System.ServiceModel.Description;

namespace Tuan4_Server
{
    public partial class Tuan4_Server : Form
    {
        
        ServiceHost myServiceHost = null;
        ServiceMetadataBehavior behavior;
        
        public Tuan4_Server()
        {
            InitializeComponent();
            bt_Stop.Enabled = false;
        }

        private void bt_Start_Click(object sender, EventArgs e)
        {
            
                

                try
                {
                    //Kết nối kiểu BasicHttpBinding
                    if (rad_BasicHttpBinding.Checked == true)
                    {
                        bt_Start.Enabled = false;
                        bt_Stop.Enabled = true;
                        myServiceHost = new ServiceHost(typeof(Server), new Uri[] {new Uri("http://localhost:8080/hello")});
                        myServiceHost.AddServiceEndpoint(typeof(IServer), new BasicHttpBinding(), "HELLO");

                        if (cb_Mex.Checked == true)
                        {
                            behavior = new ServiceMetadataBehavior { HttpGetEnabled = true };
                            myServiceHost.Description.Behaviors.Add(behavior);
                            
                            myServiceHost.AddServiceEndpoint(typeof(IMetadataExchange), new BasicHttpBinding(), "MEX1");
                        }
                        myServiceHost.Open();
                        textBox3.Text = " HELLO";
                        tb_BasicHttpBinding.Text = "http://localhost:8080/hello";
                        tb_Message.Text = "BasicHttpBinding";
                        tb_BaseAddress.Text = "http://localhost:8080/hello";
                    }

                    //Kết nối kiểu WSHttpBinding
                    if (rad_WSHttpBinding.Checked == true)
                    {
                        bt_Start.Enabled = false;
                        bt_Stop.Enabled = true;
                        myServiceHost = new ServiceHost(typeof(Server), new Uri[] { new Uri("http://localhost:8081/hello") });
                        myServiceHost.AddServiceEndpoint(typeof(IServer), new WSHttpBinding(), "HELLO");

                        if (cb_Mex.Checked == true)
                        {
                            behavior = new ServiceMetadataBehavior { HttpGetEnabled = true };
                            myServiceHost.Description.Behaviors.Add(behavior);

                            myServiceHost.AddServiceEndpoint(typeof(IMetadataExchange), new WSHttpBinding(), "MEX1");
                        }
                        myServiceHost.Open();
                        textBox6.Text = " HELLO";
                        tb_WSHttpBinding.Text = "http://localhost:8081/hello";
                        tb_Message.Text = "WsHttpBinding";
                        tb_BaseAddress.Text = "http://localhost:8081/hello";
                    }

                    //Kết nối kiểu NetTcpBinding
                    if (rad_NetTcpBinding.Checked == true && cb_Mex.Checked==true)
                    {
                        bt_Start.Enabled = false;
                        bt_Stop.Enabled = true;
                        myServiceHost = new ServiceHost(typeof(Server), new Uri[] { new Uri("net.tcp://localhost:8088/hello") });
                        myServiceHost.AddServiceEndpoint(typeof(IServer), new NetTcpBinding(), "HELLO");
                        myServiceHost.Open();
                        textBox8.Text = " HELLO";
                        tb_NetTcpBinding.Text = "net.tcp://localhost:8088/hello";
                        tb_Message.Text = "NetTcpbinding";
                        tb_BaseAddress.Text = "net.tcp://localhost:8088/hello";
                    }
                }
                catch (System.Exception ex)
                {
                    MessageBox.Show(ex.ToString(), "Lõi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        private void Tuan4_Server_Load(object sender, EventArgs e)
        {
            bt_Stop.Enabled = false;
        }

        private void bt_Stop_Click(object sender, EventArgs e)
        {
            myServiceHost.Close();
            bt_Stop.Enabled = false;
            bt_Start.Enabled = true;
            textBox3.Clear();
            textBox6.Clear();
            textBox8.Clear();
            tb_NetTcpBinding.Clear();
            tb_WSHttpBinding.Clear();
            tb_BasicHttpBinding.Clear();
            tb_BaseAddress.Clear();
        }

        
    }
}

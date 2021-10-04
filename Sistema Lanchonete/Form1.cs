using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;
using System.Runtime.InteropServices;


namespace Sistema_Lanchonete
{
    public partial class lblTitleChildForm : Form
    {
        //fields//
        private IconButton currentBtn;
        private Panel leftBorderBtn;
        private Form currentChildForm;

        public lblTitleChildForm()
        {
            InitializeComponent();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 50);
            panelMenu.Controls.Add(leftBorderBtn);
            //Tirar a barra do Form
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }
        //Estruturas
        private struct RGBColors
        {
            public static Color color3 = Color.FromArgb(255, 165, 0);
        }

        //Metodos//
        //Destacar botão
        private void ActivateButton (object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                //Botão
                DisableButton();
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb(75, 0, 130);
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;
                //botão da borda esquerda
                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0,currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();
                //atual Icone do ChildForm
                iconCurrentChildForm.IconChar = currentBtn.IconChar;
                iconCurrentChildForm.IconColor = color;
            }
        }
        //Deixar de Destacar botão
        private void DisableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(75,0,130);
                currentBtn.ForeColor = Color.Gainsboro;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.LimeGreen;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }
        //ativando cores do botão
        private void btnLoginForm1_Click(object sender, EventArgs e)
        {
            ActivateButton(sender,RGBColors.color3);
            OpenChildForm(new FormLogin());
        }

        private void btnPedidoForm1_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color3);
            OpenChildForm(new Pedido());
        }

        private void btnClienteForm1_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color3);
            OpenChildForm(new Cliente());
        }

        private void btnFinalizarForm1_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color3);
            OpenChildForm(new Finalizar());
        }

        private void btnSairForm1_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color3);
            OpenChildForm(new Sair());
        }
        //voltar no inicio
        private void btnHome_Click(object sender, EventArgs e)
        {
            currentChildForm.Close();
            Reset();

        }

        private void Reset()
        {
            DisableButton();
            leftBorderBtn.Visible = false;
            iconCurrentChildForm.IconChar = IconChar.Home;
            iconCurrentChildForm.IconColor = Color.Purple;
            lblCurrentChildForm.Text = "Inicio";
        }
        //Arrastar o Form
        [DllImport("User32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("User32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMassage(System.IntPtr hWnd,int wMsg,int wParam, int lParam);
        private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMassage(this.Handle, 0x112, 0xf012, 0);
        }
        //Abrir Forms secundarios
        private void OpenChildForm(Form childForm)
        {
            if(currentChildForm!= null)
            {
                //abrir so um form
                currentChildForm.Close();
            }
            //abrir mais de um form
            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelDesktop.Controls.Add(childForm);
            panelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lblCurrentChildForm.Text = childForm.Text;
        }
        //botao sair
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //botao maximizar
        private void iconPictureBox2_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;
            }
            else
            {
                WindowState = FormWindowState.Normal;
            }
        }
        //bota minimizar
        private void iconPictureBox1_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
    }
}

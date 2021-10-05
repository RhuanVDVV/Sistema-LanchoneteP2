
namespace Sistema_Lanchonete
{
    partial class Finalizar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridViewFormFinalizar = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtTotalFormFinalizar = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtPagamentoFormFinalizar = new System.Windows.Forms.TextBox();
            this.comboBoxFormadePagamento = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTrocoFormFinalizar = new System.Windows.Forms.TextBox();
            this.btnFinalizarFormFinalizar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFormFinalizar)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewFormFinalizar
            // 
            this.dataGridViewFormFinalizar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridViewFormFinalizar.BackgroundColor = System.Drawing.Color.PaleGreen;
            this.dataGridViewFormFinalizar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFormFinalizar.Location = new System.Drawing.Point(69, 22);
            this.dataGridViewFormFinalizar.Name = "dataGridViewFormFinalizar";
            this.dataGridViewFormFinalizar.RowTemplate.Height = 25;
            this.dataGridViewFormFinalizar.Size = new System.Drawing.Size(432, 150);
            this.dataGridViewFormFinalizar.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtTrocoFormFinalizar);
            this.panel1.Controls.Add(this.txtTotalFormFinalizar);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.txtPagamentoFormFinalizar);
            this.panel1.Controls.Add(this.comboBoxFormadePagamento);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(126, 178);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(317, 151);
            this.panel1.TabIndex = 1;
            // 
            // txtTotalFormFinalizar
            // 
            this.txtTotalFormFinalizar.Location = new System.Drawing.Point(212, 32);
            this.txtTotalFormFinalizar.Name = "txtTotalFormFinalizar";
            this.txtTotalFormFinalizar.Size = new System.Drawing.Size(100, 23);
            this.txtTotalFormFinalizar.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(168, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Total:";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Location = new System.Drawing.Point(149, 9);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(13, 100);
            this.panel3.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btnFinalizarFormFinalizar);
            this.panel2.Location = new System.Drawing.Point(95, 113);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(112, 33);
            this.panel2.TabIndex = 3;
            // 
            // txtPagamentoFormFinalizar
            // 
            this.txtPagamentoFormFinalizar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtPagamentoFormFinalizar.Location = new System.Drawing.Point(38, 70);
            this.txtPagamentoFormFinalizar.Name = "txtPagamentoFormFinalizar";
            this.txtPagamentoFormFinalizar.Size = new System.Drawing.Size(65, 23);
            this.txtPagamentoFormFinalizar.TabIndex = 2;
            this.txtPagamentoFormFinalizar.Text = "0\r\n";
            this.txtPagamentoFormFinalizar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // comboBoxFormadePagamento
            // 
            this.comboBoxFormadePagamento.FormattingEnabled = true;
            this.comboBoxFormadePagamento.Items.AddRange(new object[] {
            "Dinheiro",
            "Cartão de Crédito",
            "Cartão de Débito",
            "Pic-Pay",
            "Pix"});
            this.comboBoxFormadePagamento.Location = new System.Drawing.Point(23, 32);
            this.comboBoxFormadePagamento.Name = "comboBoxFormadePagamento";
            this.comboBoxFormadePagamento.Size = new System.Drawing.Size(100, 23);
            this.comboBoxFormadePagamento.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Forma De Pagamento";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(168, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 15);
            this.label4.TabIndex = 11;
            this.label4.Text = "Troco:";
            // 
            // txtTrocoFormFinalizar
            // 
            this.txtTrocoFormFinalizar.Location = new System.Drawing.Point(212, 70);
            this.txtTrocoFormFinalizar.Name = "txtTrocoFormFinalizar";
            this.txtTrocoFormFinalizar.Size = new System.Drawing.Size(100, 23);
            this.txtTrocoFormFinalizar.TabIndex = 10;
            // 
            // btnFinalizarFormFinalizar
            // 
            this.btnFinalizarFormFinalizar.Location = new System.Drawing.Point(20, 5);
            this.btnFinalizarFormFinalizar.Name = "btnFinalizarFormFinalizar";
            this.btnFinalizarFormFinalizar.Size = new System.Drawing.Size(75, 23);
            this.btnFinalizarFormFinalizar.TabIndex = 0;
            this.btnFinalizarFormFinalizar.Text = "Finalizar";
            this.btnFinalizarFormFinalizar.UseVisualStyleBackColor = true;
            // 
            // Finalizar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumPurple;
            this.ClientSize = new System.Drawing.Size(584, 331);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridViewFormFinalizar);
            this.Name = "Finalizar";
            this.Text = "Finalizar";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFormFinalizar)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewFormFinalizar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox comboBoxFormadePagamento;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTotalFormFinalizar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtPagamentoFormFinalizar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTrocoFormFinalizar;
        private System.Windows.Forms.Button btnFinalizarFormFinalizar;
    }
}
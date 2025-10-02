namespace kiosko_ssms.Forms
{
    partial class UserList
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserList));
            this.dgvUser = new Krypton.Toolkit.KryptonDataGridView();
            this.btnRefresh = new Krypton.Toolkit.KryptonButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblMessage = new System.Windows.Forms.ToolStripStatusLabel();
            this.contextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cONVERTIRENGERENTEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnMakeManager = new System.Windows.Forms.ToolStripMenuItem();
            this.btnMakeSeller = new System.Windows.Forms.ToolStripMenuItem();
            this.cAMBIARESTADOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnEnableUser = new System.Windows.Forms.ToolStripMenuItem();
            this.btnDisableUser = new System.Windows.Forms.ToolStripMenuItem();
            this.btnResetPassword = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUser)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.contextMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvUser
            // 
            this.dgvUser.AllowUserToAddRows = false;
            this.dgvUser.AllowUserToDeleteRows = false;
            this.dgvUser.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUser.Location = new System.Drawing.Point(12, 12);
            this.dgvUser.Name = "dgvUser";
            this.dgvUser.ReadOnly = true;
            this.dgvUser.Size = new System.Drawing.Size(944, 365);
            this.dgvUser.TabIndex = 3;
            this.dgvUser.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUser_CellClick);
            this.dgvUser.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvUser_CellFormatting);
            this.dgvUser.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvUser_CellMouseDown);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(412, 383);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.PaletteMode = Krypton.Toolkit.PaletteMode.SparkleBlue;
            this.btnRefresh.Size = new System.Drawing.Size(144, 25);
            this.btnRefresh.TabIndex = 4;
            this.btnRefresh.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.btnRefresh.Values.Text = "REFRESCAR";
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblMessage});
            this.statusStrip1.Location = new System.Drawing.Point(0, 422);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(965, 26);
            this.statusStrip1.TabIndex = 5;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblMessage
            // 
            this.lblMessage.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessage.ForeColor = System.Drawing.Color.Teal;
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(256, 21);
            this.lblMessage.Text = "TIP: Click derecho para opciones";
            // 
            // contextMenu
            // 
            this.contextMenu.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.contextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cONVERTIRENGERENTEToolStripMenuItem,
            this.cAMBIARESTADOToolStripMenuItem,
            this.btnResetPassword});
            this.contextMenu.Name = "contextMenu";
            this.contextMenu.Size = new System.Drawing.Size(208, 70);
            // 
            // cONVERTIRENGERENTEToolStripMenuItem
            // 
            this.cONVERTIRENGERENTEToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnMakeManager,
            this.btnMakeSeller});
            this.cONVERTIRENGERENTEToolStripMenuItem.Name = "cONVERTIRENGERENTEToolStripMenuItem";
            this.cONVERTIRENGERENTEToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.cONVERTIRENGERENTEToolStripMenuItem.Text = "CAMBIAR ROL";
            // 
            // btnMakeManager
            // 
            this.btnMakeManager.Name = "btnMakeManager";
            this.btnMakeManager.Size = new System.Drawing.Size(180, 22);
            this.btnMakeManager.Text = "GERENTE";
            this.btnMakeManager.Click += new System.EventHandler(this.btnMakeManager_Click);
            // 
            // btnMakeSeller
            // 
            this.btnMakeSeller.Name = "btnMakeSeller";
            this.btnMakeSeller.Size = new System.Drawing.Size(180, 22);
            this.btnMakeSeller.Text = "VENDEDOR";
            this.btnMakeSeller.Click += new System.EventHandler(this.btnMakeSeller_Click);
            // 
            // cAMBIARESTADOToolStripMenuItem
            // 
            this.cAMBIARESTADOToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnEnableUser,
            this.btnDisableUser});
            this.cAMBIARESTADOToolStripMenuItem.Name = "cAMBIARESTADOToolStripMenuItem";
            this.cAMBIARESTADOToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.cAMBIARESTADOToolStripMenuItem.Text = "CAMBIAR ESTADO";
            // 
            // btnEnableUser
            // 
            this.btnEnableUser.Name = "btnEnableUser";
            this.btnEnableUser.Size = new System.Drawing.Size(180, 22);
            this.btnEnableUser.Text = "HABILITAR";
            this.btnEnableUser.Click += new System.EventHandler(this.btnEnableUser_Click);
            // 
            // btnDisableUser
            // 
            this.btnDisableUser.Name = "btnDisableUser";
            this.btnDisableUser.Size = new System.Drawing.Size(180, 22);
            this.btnDisableUser.Text = "DESHABILITAR";
            this.btnDisableUser.Click += new System.EventHandler(this.btnDisableUser_Click);
            // 
            // btnResetPassword
            // 
            this.btnResetPassword.Name = "btnResetPassword";
            this.btnResetPassword.Size = new System.Drawing.Size(207, 22);
            this.btnResetPassword.Text = "RESETEAR CONTRASEÑA";
            this.btnResetPassword.Click += new System.EventHandler(this.btnResetPassword_Click);
            // 
            // UserList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(965, 448);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.dgvUser);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UserList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "LISTADO DE USUARIOS";
            this.Load += new System.EventHandler(this.UserList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUser)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.contextMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Krypton.Toolkit.KryptonDataGridView dgvUser;
        private Krypton.Toolkit.KryptonButton btnRefresh;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblMessage;
        private System.Windows.Forms.ContextMenuStrip contextMenu;
        private System.Windows.Forms.ToolStripMenuItem cONVERTIRENGERENTEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btnMakeManager;
        private System.Windows.Forms.ToolStripMenuItem btnMakeSeller;
        private System.Windows.Forms.ToolStripMenuItem cAMBIARESTADOToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btnEnableUser;
        private System.Windows.Forms.ToolStripMenuItem btnDisableUser;
        private System.Windows.Forms.ToolStripMenuItem btnResetPassword;
    }
}
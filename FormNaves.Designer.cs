namespace Gestor_de_Expedicions_Espacials
{
    partial class FormNaves
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
            dataGridViewNaves = new DataGridView();
            btnAddShip = new Button();
            btnModificarNau = new Button();
            btnElminarNau = new Button();
            btnLlistarNau = new Button();
            textBoxNom = new TextBox();
            textBoxModel = new TextBox();
            textBoxCapacitat = new TextBox();
            menuStrip1 = new MenuStrip();
            expeditionsToolStripMenuItem = new ToolStripMenuItem();
            astronautsToolStripMenuItem = new ToolStripMenuItem();
            spaceshipsToolStripMenuItem = new ToolStripMenuItem();
            logOutToolStripMenuItem = new ToolStripMenuItem();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewNaves).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridViewNaves
            // 
            dataGridViewNaves.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewNaves.GridColor = SystemColors.MenuHighlight;
            dataGridViewNaves.Location = new Point(178, 140);
            dataGridViewNaves.Name = "dataGridViewNaves";
            dataGridViewNaves.RowHeadersWidth = 51;
            dataGridViewNaves.Size = new Size(428, 224);
            dataGridViewNaves.TabIndex = 0;
            // 
            // btnAddShip
            // 
            btnAddShip.Location = new Point(168, 389);
            btnAddShip.Name = "btnAddShip";
            btnAddShip.Size = new Size(94, 29);
            btnAddShip.TabIndex = 1;
            btnAddShip.Text = "Add ship";
            btnAddShip.UseVisualStyleBackColor = true;
            btnAddShip.Click += btnAddShip_Click;
            // 
            // btnModificarNau
            // 
            btnModificarNau.Location = new Point(279, 389);
            btnModificarNau.Name = "btnModificarNau";
            btnModificarNau.Size = new Size(114, 29);
            btnModificarNau.TabIndex = 2;
            btnModificarNau.Text = "Modify ship";
            btnModificarNau.UseVisualStyleBackColor = true;
            btnModificarNau.Click += btnModificarNau_Click;
            // 
            // btnElminarNau
            // 
            btnElminarNau.Location = new Point(416, 389);
            btnElminarNau.Name = "btnElminarNau";
            btnElminarNau.Size = new Size(94, 29);
            btnElminarNau.TabIndex = 3;
            btnElminarNau.Text = "Delete ship";
            btnElminarNau.UseVisualStyleBackColor = true;
            btnElminarNau.Click += btnElminarNau_Click;
            // 
            // btnLlistarNau
            // 
            btnLlistarNau.Location = new Point(529, 389);
            btnLlistarNau.Name = "btnLlistarNau";
            btnLlistarNau.Size = new Size(94, 29);
            btnLlistarNau.TabIndex = 4;
            btnLlistarNau.Text = "List ship";
            btnLlistarNau.UseVisualStyleBackColor = true;
            btnLlistarNau.Click += btnLlistarNau_Click;
            // 
            // textBoxNom
            // 
            textBoxNom.Location = new Point(168, 47);
            textBoxNom.Name = "textBoxNom";
            textBoxNom.Size = new Size(125, 27);
            textBoxNom.TabIndex = 5;
            // 
            // textBoxModel
            // 
            textBoxModel.Location = new Point(323, 47);
            textBoxModel.Name = "textBoxModel";
            textBoxModel.Size = new Size(125, 27);
            textBoxModel.TabIndex = 6;
            // 
            // textBoxCapacitat
            // 
            textBoxCapacitat.Location = new Point(481, 47);
            textBoxCapacitat.Name = "textBoxCapacitat";
            textBoxCapacitat.Size = new Size(125, 27);
            textBoxCapacitat.TabIndex = 7;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { expeditionsToolStripMenuItem, astronautsToolStripMenuItem, spaceshipsToolStripMenuItem, logOutToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 28);
            menuStrip1.TabIndex = 8;
            menuStrip1.Text = "menuStrip1";
            // 
            // expeditionsToolStripMenuItem
            // 
            expeditionsToolStripMenuItem.Name = "expeditionsToolStripMenuItem";
            expeditionsToolStripMenuItem.Size = new Size(100, 24);
            expeditionsToolStripMenuItem.Text = "Expeditions";
            expeditionsToolStripMenuItem.Click += expeditionsToolStripMenuItem_Click;
            // 
            // astronautsToolStripMenuItem
            // 
            astronautsToolStripMenuItem.Name = "astronautsToolStripMenuItem";
            astronautsToolStripMenuItem.Size = new Size(93, 24);
            astronautsToolStripMenuItem.Text = "Astronauts";
            astronautsToolStripMenuItem.Click += astronautsToolStripMenuItem_Click;
            // 
            // spaceshipsToolStripMenuItem
            // 
            spaceshipsToolStripMenuItem.Name = "spaceshipsToolStripMenuItem";
            spaceshipsToolStripMenuItem.Size = new Size(96, 24);
            spaceshipsToolStripMenuItem.Text = "Spaceships";
            spaceshipsToolStripMenuItem.Click += spaceshipsToolStripMenuItem_Click;
            // 
            // logOutToolStripMenuItem
            // 
            logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            logOutToolStripMenuItem.Size = new Size(74, 24);
            logOutToolStripMenuItem.Text = "Log out";
            logOutToolStripMenuItem.Click += logOutToolStripMenuItem_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(353, 77);
            label1.Name = "label1";
            label1.Size = new Size(52, 20);
            label1.TabIndex = 9;
            label1.Text = "Model";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(204, 77);
            label2.Name = "label2";
            label2.Size = new Size(49, 20);
            label2.TabIndex = 10;
            label2.Text = "Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(510, 77);
            label3.Name = "label3";
            label3.Size = new Size(66, 20);
            label3.TabIndex = 11;
            label3.Text = "Capacity";
            // 
            // FormNaves
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBoxCapacitat);
            Controls.Add(textBoxModel);
            Controls.Add(textBoxNom);
            Controls.Add(btnLlistarNau);
            Controls.Add(btnElminarNau);
            Controls.Add(btnModificarNau);
            Controls.Add(btnAddShip);
            Controls.Add(dataGridViewNaves);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "FormNaves";
            Text = "FormNaves";
            ((System.ComponentModel.ISupportInitialize)dataGridViewNaves).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewNaves;
        private Button btnAddShip;
        private Button btnModificarNau;
        private Button btnElminarNau;
        private Button btnLlistarNau;
        private TextBox textBoxNom;
        private TextBox textBoxModel;
        private TextBox textBoxCapacitat;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem expeditionsToolStripMenuItem;
        private ToolStripMenuItem astronautsToolStripMenuItem;
        private ToolStripMenuItem spaceshipsToolStripMenuItem;
        private ToolStripMenuItem logOutToolStripMenuItem;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}
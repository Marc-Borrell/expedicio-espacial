namespace Gestor_de_Expedicions_Espacials
{
    partial class FormAstronautas
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
            dataGridViewAstronautas = new DataGridView();
            btnAfegirAstronauta = new Button();
            btnModificarAstronauta = new Button();
            btnEliminarAstronauta = new Button();
            btnLlistarAstronauta = new Button();
            menuStrip1 = new MenuStrip();
            exepeditionsToolStripMenuItem = new ToolStripMenuItem();
            astronautsToolStripMenuItem = new ToolStripMenuItem();
            spaceshipsToolStripMenuItem = new ToolStripMenuItem();
            logOutToolStripMenuItem = new ToolStripMenuItem();
            textBoxNom = new TextBox();
            textBoxEdat = new TextBox();
            textBoxEspecialitat = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewAstronautas).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridViewAstronautas
            // 
            dataGridViewAstronautas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewAstronautas.GridColor = SystemColors.MenuHighlight;
            dataGridViewAstronautas.Location = new Point(130, 129);
            dataGridViewAstronautas.Name = "dataGridViewAstronautas";
            dataGridViewAstronautas.RowHeadersWidth = 51;
            dataGridViewAstronautas.Size = new Size(540, 254);
            dataGridViewAstronautas.TabIndex = 0;
            // 
            // btnAfegirAstronauta
            // 
            btnAfegirAstronauta.Location = new Point(103, 405);
            btnAfegirAstronauta.Name = "btnAfegirAstronauta";
            btnAfegirAstronauta.Size = new Size(118, 29);
            btnAfegirAstronauta.TabIndex = 1;
            btnAfegirAstronauta.Text = "add astronaut";
            btnAfegirAstronauta.UseVisualStyleBackColor = true;
            btnAfegirAstronauta.Click += btnAfegirAstronauta_Click;
            // 
            // btnModificarAstronauta
            // 
            btnModificarAstronauta.Location = new Point(240, 405);
            btnModificarAstronauta.Name = "btnModificarAstronauta";
            btnModificarAstronauta.Size = new Size(134, 29);
            btnModificarAstronauta.TabIndex = 2;
            btnModificarAstronauta.Text = "modify astronaut";
            btnModificarAstronauta.UseVisualStyleBackColor = true;
            btnModificarAstronauta.Click += btnModificarAstronauta_Click;
            // 
            // btnEliminarAstronauta
            // 
            btnEliminarAstronauta.Location = new Point(400, 405);
            btnEliminarAstronauta.Name = "btnEliminarAstronauta";
            btnEliminarAstronauta.Size = new Size(136, 29);
            btnEliminarAstronauta.TabIndex = 3;
            btnEliminarAstronauta.Text = "delete astronaut";
            btnEliminarAstronauta.UseVisualStyleBackColor = true;
            btnEliminarAstronauta.Click += btnEliminarAstronauta_Click;
            // 
            // btnLlistarAstronauta
            // 
            btnLlistarAstronauta.Location = new Point(555, 405);
            btnLlistarAstronauta.Name = "btnLlistarAstronauta";
            btnLlistarAstronauta.Size = new Size(139, 29);
            btnLlistarAstronauta.TabIndex = 4;
            btnLlistarAstronauta.Text = "list astronaut";
            btnLlistarAstronauta.UseVisualStyleBackColor = true;
            btnLlistarAstronauta.Click += btnLlistarAstronauta_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { exepeditionsToolStripMenuItem, astronautsToolStripMenuItem, spaceshipsToolStripMenuItem, logOutToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 28);
            menuStrip1.TabIndex = 5;
            menuStrip1.Text = "menuStrip1";
            // 
            // exepeditionsToolStripMenuItem
            // 
            exepeditionsToolStripMenuItem.Name = "exepeditionsToolStripMenuItem";
            exepeditionsToolStripMenuItem.Size = new Size(108, 24);
            exepeditionsToolStripMenuItem.Text = "Exepeditions";
            exepeditionsToolStripMenuItem.Click += exepeditionsToolStripMenuItem_Click;
            // 
            // astronautsToolStripMenuItem
            // 
            astronautsToolStripMenuItem.Name = "astronautsToolStripMenuItem";
            astronautsToolStripMenuItem.Size = new Size(93, 24);
            astronautsToolStripMenuItem.Text = "Astronauts";
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
            // textBoxNom
            // 
            textBoxNom.Location = new Point(169, 46);
            textBoxNom.Name = "textBoxNom";
            textBoxNom.Size = new Size(125, 27);
            textBoxNom.TabIndex = 6;
            // 
            // textBoxEdat
            // 
            textBoxEdat.Location = new Point(335, 46);
            textBoxEdat.Name = "textBoxEdat";
            textBoxEdat.Size = new Size(125, 27);
            textBoxEdat.TabIndex = 7;
            // 
            // textBoxEspecialitat
            // 
            textBoxEspecialitat.Location = new Point(503, 46);
            textBoxEspecialitat.Name = "textBoxEspecialitat";
            textBoxEspecialitat.Size = new Size(125, 27);
            textBoxEspecialitat.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(209, 76);
            label1.Name = "label1";
            label1.Size = new Size(49, 20);
            label1.TabIndex = 9;
            label1.Text = "Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(378, 76);
            label2.Name = "label2";
            label2.Size = new Size(36, 20);
            label2.TabIndex = 10;
            label2.Text = "Age";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(531, 76);
            label3.Name = "label3";
            label3.Size = new Size(69, 20);
            label3.TabIndex = 11;
            label3.Text = "Specialty";
            // 
            // FormAstronautas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBoxEspecialitat);
            Controls.Add(textBoxEdat);
            Controls.Add(textBoxNom);
            Controls.Add(btnLlistarAstronauta);
            Controls.Add(btnEliminarAstronauta);
            Controls.Add(btnModificarAstronauta);
            Controls.Add(btnAfegirAstronauta);
            Controls.Add(dataGridViewAstronautas);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "FormAstronautas";
            Text = "FormAstronautas";
            ((System.ComponentModel.ISupportInitialize)dataGridViewAstronautas).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewAstronautas;
        private Button btnAfegirAstronauta;
        private Button btnModificarAstronauta;
        private Button btnEliminarAstronauta;
        private Button btnLlistarAstronauta;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem exepeditionsToolStripMenuItem;
        private ToolStripMenuItem astronautsToolStripMenuItem;
        private ToolStripMenuItem spaceshipsToolStripMenuItem;
        private ToolStripMenuItem logOutToolStripMenuItem;
        private TextBox textBoxNom;
        private TextBox textBoxEdat;
        private TextBox textBoxEspecialitat;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}
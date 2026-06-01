namespace Gestor_de_Expedicions_Espacials
{
    partial class Form2
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
            dataGridViewExpediciones = new DataGridView();
            btnAfegirExpedicio = new Button();
            btnModificarExpedicio = new Button();
            btnEliminarExpedicio = new Button();
            textBoxDesti = new TextBox();
            dateTimePickerDataSortida = new DateTimePicker();
            textBoxDuracio = new TextBox();
            textBoxNauId = new TextBox();
            menuStrip1 = new MenuStrip();
            expeditionsToolStripMenuItem = new ToolStripMenuItem();
            astronautsToolStripMenuItem = new ToolStripMenuItem();
            spaceshipsToolStripMenuItem = new ToolStripMenuItem();
            logOutToolStripMenuItem = new ToolStripMenuItem();
            btnLlistarExpedicio = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewExpediciones).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridViewExpediciones
            // 
            dataGridViewExpediciones.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewExpediciones.GridColor = SystemColors.MenuHighlight;
            dataGridViewExpediciones.Location = new Point(127, 130);
            dataGridViewExpediciones.Name = "dataGridViewExpediciones";
            dataGridViewExpediciones.RowHeadersWidth = 51;
            dataGridViewExpediciones.Size = new Size(545, 272);
            dataGridViewExpediciones.TabIndex = 0;
            // 
            // btnAfegirExpedicio
            // 
            btnAfegirExpedicio.Location = new Point(55, 437);
            btnAfegirExpedicio.Name = "btnAfegirExpedicio";
            btnAfegirExpedicio.Size = new Size(124, 29);
            btnAfegirExpedicio.TabIndex = 1;
            btnAfegirExpedicio.Text = "add expedition";
            btnAfegirExpedicio.UseVisualStyleBackColor = true;
            btnAfegirExpedicio.Click += btnAfegirExpedicio_Click;
            // 
            // btnModificarExpedicio
            // 
            btnModificarExpedicio.Location = new Point(195, 437);
            btnModificarExpedicio.Name = "btnModificarExpedicio";
            btnModificarExpedicio.Size = new Size(148, 29);
            btnModificarExpedicio.TabIndex = 2;
            btnModificarExpedicio.Text = "modify expedition";
            btnModificarExpedicio.UseVisualStyleBackColor = true;
            btnModificarExpedicio.Click += btnModificarExpedicio_Click;
            // 
            // btnEliminarExpedicio
            // 
            btnEliminarExpedicio.Location = new Point(363, 437);
            btnEliminarExpedicio.Name = "btnEliminarExpedicio";
            btnEliminarExpedicio.Size = new Size(161, 29);
            btnEliminarExpedicio.TabIndex = 3;
            btnEliminarExpedicio.Text = "delete expedition";
            btnEliminarExpedicio.UseVisualStyleBackColor = true;
            btnEliminarExpedicio.Click += btnEliminarExpedicio_Click;
            // 
            // textBoxDesti
            // 
            textBoxDesti.Location = new Point(54, 56);
            textBoxDesti.Name = "textBoxDesti";
            textBoxDesti.Size = new Size(125, 27);
            textBoxDesti.TabIndex = 4;
            // 
            // dateTimePickerDataSortida
            // 
            dateTimePickerDataSortida.Location = new Point(491, 56);
            dateTimePickerDataSortida.Name = "dateTimePickerDataSortida";
            dateTimePickerDataSortida.Size = new Size(225, 27);
            dateTimePickerDataSortida.TabIndex = 5;
            // 
            // textBoxDuracio
            // 
            textBoxDuracio.Location = new Point(195, 56);
            textBoxDuracio.Name = "textBoxDuracio";
            textBoxDuracio.Size = new Size(125, 27);
            textBoxDuracio.TabIndex = 6;
            // 
            // textBoxNauId
            // 
            textBoxNauId.Location = new Point(338, 56);
            textBoxNauId.Name = "textBoxNauId";
            textBoxNauId.Size = new Size(125, 27);
            textBoxNauId.TabIndex = 7;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { expeditionsToolStripMenuItem, astronautsToolStripMenuItem, spaceshipsToolStripMenuItem, logOutToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(767, 28);
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
            // btnLlistarExpedicio
            // 
            btnLlistarExpedicio.Location = new Point(545, 437);
            btnLlistarExpedicio.Name = "btnLlistarExpedicio";
            btnLlistarExpedicio.Size = new Size(127, 29);
            btnLlistarExpedicio.TabIndex = 9;
            btnLlistarExpedicio.Text = "list expedition";
            btnLlistarExpedicio.UseVisualStyleBackColor = true;
            btnLlistarExpedicio.Click += btnLlistarExpedicio_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(85, 86);
            label1.Name = "label1";
            label1.Size = new Size(58, 20);
            label1.TabIndex = 10;
            label1.Text = "Destiny";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(234, 86);
            label2.Name = "label2";
            label2.Size = new Size(67, 20);
            label2.TabIndex = 11;
            label2.Text = "Duration";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(380, 86);
            label3.Name = "label3";
            label3.Size = new Size(55, 20);
            label3.TabIndex = 12;
            label3.Text = "ID ship";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(569, 86);
            label4.Name = "label4";
            label4.Size = new Size(89, 20);
            label4.TabIndex = 13;
            label4.Text = "Output date";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(767, 526);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnLlistarExpedicio);
            Controls.Add(textBoxNauId);
            Controls.Add(textBoxDuracio);
            Controls.Add(dateTimePickerDataSortida);
            Controls.Add(textBoxDesti);
            Controls.Add(btnEliminarExpedicio);
            Controls.Add(btnModificarExpedicio);
            Controls.Add(btnAfegirExpedicio);
            Controls.Add(dataGridViewExpediciones);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewExpediciones).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewExpediciones;
        private Button btnAfegirExpedicio;
        private Button btnModificarExpedicio;
        private Button btnEliminarExpedicio;
        private TextBox textBoxDesti;
        private DateTimePicker dateTimePickerDataSortida;
        private TextBox textBoxDuracio;
        private TextBox textBoxNauId;
        private MenuStrip menuStrip1;
        private Button btnLlistarExpedicio;
        private ToolStripMenuItem expeditionsToolStripMenuItem;
        private ToolStripMenuItem astronautsToolStripMenuItem;
        private ToolStripMenuItem spaceshipsToolStripMenuItem;
        private ToolStripMenuItem logOutToolStripMenuItem;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}
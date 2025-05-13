namespace zenesszar
{
    partial class MusicAdd
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
            components = new System.ComponentModel.Container();
            textBox1 = new TextBox();
            pathLabel = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            bindingSource1 = new BindingSource(components);
            textBox4 = new TextBox();
            label4 = new Label();
            Add = new Button();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(129, 134);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 0;
            // 
            // pathLabel
            // 
            pathLabel.AutoSize = true;
            pathLabel.Font = new Font("Segoe UI", 15F);
            pathLabel.Location = new Point(25, 9);
            pathLabel.Name = "pathLabel";
            pathLabel.Size = new Size(52, 28);
            pathLabel.TabIndex = 1;
            pathLabel.Text = "path";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(71, 138);
            label1.Name = "label1";
            label1.Size = new Size(27, 15);
            label1.TabIndex = 2;
            label1.Text = "cim";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(71, 184);
            label2.Name = "label2";
            label2.Size = new Size(43, 15);
            label2.TabIndex = 3;
            label2.Text = "eloado";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(71, 226);
            label3.Name = "label3";
            label3.Size = new Size(38, 15);
            label3.TabIndex = 4;
            label3.Text = "mufaj";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(129, 184);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 5;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(129, 226);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 6;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(129, 274);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(100, 23);
            textBox4.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(71, 277);
            label4.Name = "label4";
            label4.Size = new Size(36, 15);
            label4.TabIndex = 8;
            label4.Text = "hossz";
            // 
            // Add
            // 
            Add.Location = new Point(121, 368);
            Add.Name = "Add";
            Add.Size = new Size(75, 23);
            Add.TabIndex = 9;
            Add.Text = "Hozzad";
            Add.UseVisualStyleBackColor = true;
            Add.Click += Add_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // MusicAdd
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(291, 450);
            Controls.Add(Add);
            Controls.Add(label4);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pathLabel);
            Controls.Add(textBox1);
            Name = "MusicAdd";
            Text = "MusicAdd";
            Load += MusicAdd_Load;
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Label pathLabel;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBox2;
        private TextBox textBox3;
        private BindingSource bindingSource1;
        private TextBox textBox4;
        private Label label4;
        private Button Add;
        private ErrorProvider errorProvider1;
    }
}
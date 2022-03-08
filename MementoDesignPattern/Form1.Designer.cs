
namespace MementoDesignPattern
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Undo_btn = new System.Windows.Forms.Button();
            this.Redo_btn = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.Save_btn = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.UndoStack_listBox = new System.Windows.Forms.ListBox();
            this.RedoStack_listBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ClearHistory_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Undo_btn
            // 
            this.Undo_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Undo_btn.ForeColor = System.Drawing.Color.Purple;
            this.Undo_btn.Location = new System.Drawing.Point(72, 37);
            this.Undo_btn.Name = "Undo_btn";
            this.Undo_btn.Size = new System.Drawing.Size(100, 35);
            this.Undo_btn.TabIndex = 0;
            this.Undo_btn.TabStop = false;
            this.Undo_btn.Text = "Undo";
            this.Undo_btn.UseVisualStyleBackColor = true;
            this.Undo_btn.Click += new System.EventHandler(this.Undo_btn_Click);
            // 
            // Redo_btn
            // 
            this.Redo_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Redo_btn.ForeColor = System.Drawing.Color.Purple;
            this.Redo_btn.Location = new System.Drawing.Point(282, 37);
            this.Redo_btn.Name = "Redo_btn";
            this.Redo_btn.Size = new System.Drawing.Size(100, 35);
            this.Redo_btn.TabIndex = 1;
            this.Redo_btn.TabStop = false;
            this.Redo_btn.Text = "Redo";
            this.Redo_btn.UseVisualStyleBackColor = true;
            this.Redo_btn.Click += new System.EventHandler(this.Redo_btn_Click);
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.Silver;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox2.Location = new System.Drawing.Point(72, 215);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(310, 31);
            this.textBox2.TabIndex = 3;
            this.textBox2.TabStop = false;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // Save_btn
            // 
            this.Save_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Save_btn.ForeColor = System.Drawing.Color.DarkGreen;
            this.Save_btn.Location = new System.Drawing.Point(443, 132);
            this.Save_btn.Name = "Save_btn";
            this.Save_btn.Size = new System.Drawing.Size(100, 35);
            this.Save_btn.TabIndex = 1;
            this.Save_btn.Text = "Save";
            this.Save_btn.UseVisualStyleBackColor = true;
            this.Save_btn.Click += new System.EventHandler(this.Save_btn_Click);
            // 
            // textBox1
            // 
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::MementoDesignPattern.Properties.Settings.Default, "text1", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(72, 136);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(310, 31);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = global::MementoDesignPattern.Properties.Settings.Default.text1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // UndoStack_listBox
            // 
            this.UndoStack_listBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UndoStack_listBox.FormattingEnabled = true;
            this.UndoStack_listBox.ItemHeight = 20;
            this.UndoStack_listBox.Location = new System.Drawing.Point(72, 293);
            this.UndoStack_listBox.Name = "UndoStack_listBox";
            this.UndoStack_listBox.Size = new System.Drawing.Size(310, 144);
            this.UndoStack_listBox.TabIndex = 7;
            this.UndoStack_listBox.TabStop = false;
            // 
            // RedoStack_listBox
            // 
            this.RedoStack_listBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RedoStack_listBox.FormattingEnabled = true;
            this.RedoStack_listBox.ItemHeight = 20;
            this.RedoStack_listBox.Location = new System.Drawing.Point(72, 495);
            this.RedoStack_listBox.Name = "RedoStack_listBox";
            this.RedoStack_listBox.Size = new System.Drawing.Size(310, 144);
            this.RedoStack_listBox.TabIndex = 8;
            this.RedoStack_listBox.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label1.Location = new System.Drawing.Point(68, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Enter your text:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label2.Location = new System.Drawing.Point(68, 192);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(165, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Last Save (Memento):";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label3.Location = new System.Drawing.Point(68, 270);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Undo History:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label4.Location = new System.Drawing.Point(68, 472);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "Redo History:";
            // 
            // ClearHistory_btn
            // 
            this.ClearHistory_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ClearHistory_btn.ForeColor = System.Drawing.Color.Crimson;
            this.ClearHistory_btn.Location = new System.Drawing.Point(443, 293);
            this.ClearHistory_btn.Name = "ClearHistory_btn";
            this.ClearHistory_btn.Size = new System.Drawing.Size(100, 62);
            this.ClearHistory_btn.TabIndex = 13;
            this.ClearHistory_btn.TabStop = false;
            this.ClearHistory_btn.Text = "Clear History";
            this.ClearHistory_btn.UseVisualStyleBackColor = true;
            this.ClearHistory_btn.Click += new System.EventHandler(this.ClearHistory_btn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(576, 724);
            this.Controls.Add(this.ClearHistory_btn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RedoStack_listBox);
            this.Controls.Add(this.UndoStack_listBox);
            this.Controls.Add(this.Save_btn);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Redo_btn);
            this.Controls.Add(this.Undo_btn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Memento Design Pattern";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Undo_btn;
        private System.Windows.Forms.Button Redo_btn;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button Save_btn;
        private System.Windows.Forms.ListBox UndoStack_listBox;
        private System.Windows.Forms.ListBox RedoStack_listBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button ClearHistory_btn;
    }
}


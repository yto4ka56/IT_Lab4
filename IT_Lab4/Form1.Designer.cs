namespace IT_Lab4;

partial class Form1
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
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
        menuStrip1 = new System.Windows.Forms.MenuStrip();
        файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        openFileButton = new System.Windows.Forms.ToolStripMenuItem();
        pTextBox = new System.Windows.Forms.TextBox();
        hTextBox = new System.Windows.Forms.TextBox();
        xTextBox = new System.Windows.Forms.TextBox();
        kTextBox = new System.Windows.Forms.TextBox();
        label1 = new System.Windows.Forms.Label();
        label2 = new System.Windows.Forms.Label();
        label3 = new System.Windows.Forms.Label();
        label4 = new System.Windows.Forms.Label();
        label5 = new System.Windows.Forms.Label();
        qTextBox = new System.Windows.Forms.TextBox();
        button1 = new System.Windows.Forms.Button();
        button2 = new System.Windows.Forms.Button();
        ContentTextBox = new System.Windows.Forms.TextBox();
        label6 = new System.Windows.Forms.Label();
        HashTextBox = new System.Windows.Forms.TextBox();
        SignTextBox = new System.Windows.Forms.TextBox();
        label7 = new System.Windows.Forms.Label();
        label8 = new System.Windows.Forms.Label();
        OpenFileDialog = new System.Windows.Forms.OpenFileDialog();
        menuStrip1.SuspendLayout();
        SuspendLayout();
        // 
        // menuStrip1
        // 
        menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
        menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { файлToolStripMenuItem });
        menuStrip1.Location = new System.Drawing.Point(0, 0);
        menuStrip1.Name = "menuStrip1";
        menuStrip1.Size = new System.Drawing.Size(963, 33);
        menuStrip1.TabIndex = 0;
        menuStrip1.Text = "menuStrip1";
        // 
        // файлToolStripMenuItem
        // 
        файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { openFileButton });
        файлToolStripMenuItem.Name = "файлToolStripMenuItem";
        файлToolStripMenuItem.Size = new System.Drawing.Size(69, 29);
        файлToolStripMenuItem.Text = "&Файл";
        // 
        // openFileButton
        // 
        openFileButton.Image = ((System.Drawing.Image)resources.GetObject("openFileButton.Image"));
        openFileButton.ImageTransparentColor = System.Drawing.Color.Magenta;
        openFileButton.Name = "openFileButton";
        openFileButton.ShortcutKeys = ((System.Windows.Forms.Keys)(System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O));
        openFileButton.Size = new System.Drawing.Size(270, 34);
        openFileButton.Text = "&Открыть";
        openFileButton.Click += OpenFileClick;
        // 
        // pTextBox
        // 
        pTextBox.Font = new System.Drawing.Font("Segoe UI", 14F);
        pTextBox.Location = new System.Drawing.Point(121, 163);
        pTextBox.Name = "pTextBox";
        pTextBox.Size = new System.Drawing.Size(149, 45);
        pTextBox.TabIndex = 2;
        // 
        // hTextBox
        // 
        hTextBox.Font = new System.Drawing.Font("Segoe UI", 14F);
        hTextBox.Location = new System.Drawing.Point(121, 225);
        hTextBox.Name = "hTextBox";
        hTextBox.Size = new System.Drawing.Size(149, 45);
        hTextBox.TabIndex = 3;
        // 
        // xTextBox
        // 
        xTextBox.Font = new System.Drawing.Font("Segoe UI", 14F);
        xTextBox.Location = new System.Drawing.Point(121, 291);
        xTextBox.Name = "xTextBox";
        xTextBox.Size = new System.Drawing.Size(149, 45);
        xTextBox.TabIndex = 4;
        // 
        // kTextBox
        // 
        kTextBox.Font = new System.Drawing.Font("Segoe UI", 14F);
        kTextBox.Location = new System.Drawing.Point(121, 355);
        kTextBox.Name = "kTextBox";
        kTextBox.Size = new System.Drawing.Size(149, 45);
        kTextBox.TabIndex = 5;
        // 
        // label1
        // 
        label1.Font = new System.Drawing.Font("Segoe UI", 14F);
        label1.Location = new System.Drawing.Point(63, 101);
        label1.Name = "label1";
        label1.Size = new System.Drawing.Size(52, 45);
        label1.TabIndex = 6;
        label1.Text = "q:";
        // 
        // label2
        // 
        label2.Font = new System.Drawing.Font("Segoe UI", 14F);
        label2.Location = new System.Drawing.Point(63, 163);
        label2.Name = "label2";
        label2.Size = new System.Drawing.Size(52, 45);
        label2.TabIndex = 7;
        label2.Text = "p:";
        // 
        // label3
        // 
        label3.Font = new System.Drawing.Font("Segoe UI", 14F);
        label3.Location = new System.Drawing.Point(63, 225);
        label3.Name = "label3";
        label3.Size = new System.Drawing.Size(52, 45);
        label3.TabIndex = 8;
        label3.Text = "h:";
        // 
        // label4
        // 
        label4.Font = new System.Drawing.Font("Segoe UI", 14F);
        label4.Location = new System.Drawing.Point(63, 291);
        label4.Name = "label4";
        label4.Size = new System.Drawing.Size(52, 45);
        label4.TabIndex = 9;
        label4.Text = "x:";
        // 
        // label5
        // 
        label5.Font = new System.Drawing.Font("Segoe UI", 14F);
        label5.Location = new System.Drawing.Point(63, 355);
        label5.Name = "label5";
        label5.Size = new System.Drawing.Size(52, 45);
        label5.TabIndex = 10;
        label5.Text = "k:";
        // 
        // qTextBox
        // 
        qTextBox.Font = new System.Drawing.Font("Segoe UI", 14F);
        qTextBox.Location = new System.Drawing.Point(121, 101);
        qTextBox.Name = "qTextBox";
        qTextBox.Size = new System.Drawing.Size(149, 45);
        qTextBox.TabIndex = 11;
        // 
        // button1
        // 
        button1.Font = new System.Drawing.Font("Segoe UI", 13F);
        button1.Location = new System.Drawing.Point(63, 457);
        button1.Name = "button1";
        button1.Size = new System.Drawing.Size(211, 62);
        button1.TabIndex = 12;
        button1.Text = "Подписать";
        button1.UseVisualStyleBackColor = true;
        button1.Click += SignButtonClick;
        // 
        // button2
        // 
        button2.Font = new System.Drawing.Font("Segoe UI", 13F);
        button2.Location = new System.Drawing.Point(63, 559);
        button2.Name = "button2";
        button2.Size = new System.Drawing.Size(211, 62);
        button2.TabIndex = 13;
        button2.Text = "Проверить";
        button2.UseVisualStyleBackColor = true;
        button2.Click += CheckButtonClick;
        // 
        // ContentTextBox
        // 
        ContentTextBox.Font = new System.Drawing.Font("Segoe UI", 14F);
        ContentTextBox.Location = new System.Drawing.Point(417, 156);
        ContentTextBox.Multiline = true;
        ContentTextBox.Name = "ContentTextBox";
        ContentTextBox.ReadOnly = true;
        ContentTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
        ContentTextBox.Size = new System.Drawing.Size(460, 244);
        ContentTextBox.TabIndex = 14;
        // 
        // label6
        // 
        label6.Font = new System.Drawing.Font("Segoe UI", 14F);
        label6.Location = new System.Drawing.Point(417, 101);
        label6.Name = "label6";
        label6.Size = new System.Drawing.Size(365, 41);
        label6.TabIndex = 15;
        label6.Text = "Содержимое файла:";
        // 
        // HashTextBox
        // 
        HashTextBox.Font = new System.Drawing.Font("Segoe UI", 14F);
        HashTextBox.Location = new System.Drawing.Point(417, 524);
        HashTextBox.Name = "HashTextBox";
        HashTextBox.ReadOnly = true;
        HashTextBox.Size = new System.Drawing.Size(163, 45);
        HashTextBox.TabIndex = 16;
        // 
        // SignTextBox
        // 
        SignTextBox.Font = new System.Drawing.Font("Segoe UI", 14F);
        SignTextBox.Location = new System.Drawing.Point(714, 524);
        SignTextBox.Name = "SignTextBox";
        SignTextBox.ReadOnly = true;
        SignTextBox.Size = new System.Drawing.Size(163, 45);
        SignTextBox.TabIndex = 17;
        // 
        // label7
        // 
        label7.Font = new System.Drawing.Font("Segoe UI", 14F);
        label7.Location = new System.Drawing.Point(417, 477);
        label7.Name = "label7";
        label7.Size = new System.Drawing.Size(186, 42);
        label7.TabIndex = 18;
        label7.Text = "Хеш-образ:";
        // 
        // label8
        // 
        label8.Font = new System.Drawing.Font("Segoe UI", 14F);
        label8.Location = new System.Drawing.Point(714, 477);
        label8.Name = "label8";
        label8.Size = new System.Drawing.Size(186, 42);
        label8.TabIndex = 19;
        label8.Text = "ЭЦП:";
        // 
        // Form1
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(963, 692);
        Controls.Add(label8);
        Controls.Add(label7);
        Controls.Add(SignTextBox);
        Controls.Add(HashTextBox);
        Controls.Add(label6);
        Controls.Add(ContentTextBox);
        Controls.Add(button2);
        Controls.Add(button1);
        Controls.Add(qTextBox);
        Controls.Add(label5);
        Controls.Add(label4);
        Controls.Add(label3);
        Controls.Add(label2);
        Controls.Add(label1);
        Controls.Add(kTextBox);
        Controls.Add(xTextBox);
        Controls.Add(hTextBox);
        Controls.Add(pTextBox);
        Controls.Add(menuStrip1);
        MainMenuStrip = menuStrip1;
        StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        Text = "Лабораторная №4";
        menuStrip1.ResumeLayout(false);
        menuStrip1.PerformLayout();
        ResumeLayout(false);
        PerformLayout();
    }

    private System.Windows.Forms.OpenFileDialog OpenFileDialog;

    private System.Windows.Forms.Label label8;

    private System.Windows.Forms.Label label7;

    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.TextBox HashTextBox;
    private System.Windows.Forms.TextBox SignTextBox;

    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.Button button2;
    private System.Windows.Forms.TextBox ContentTextBox;

    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Label label5;

    private System.Windows.Forms.TextBox qTextBox;
    private System.Windows.Forms.TextBox hTextBox;
    private System.Windows.Forms.TextBox xTextBox;
    private System.Windows.Forms.TextBox kTextBox;

    private System.Windows.Forms.TextBox pTextBox;

    private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem openFileButton;

    private System.Windows.Forms.MenuStrip menuStrip1;

    #endregion
}
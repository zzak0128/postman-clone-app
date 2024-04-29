namespace PostmanCloneUI;

partial class Dashboard
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
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        SuspendLayout();
        // 
        // Dashboard
        // 
        AutoScaleDimensions = new SizeF(13F, 32F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(1625, 1105);
        Font = new Font("Segoe UI", 18F);
        Margin = new Padding(6, 6, 6, 6);
        Name = "Dashboard";
        Text = "Postman Clone by Zach Zak";
        ResumeLayout(false);
    }

    #endregion
}

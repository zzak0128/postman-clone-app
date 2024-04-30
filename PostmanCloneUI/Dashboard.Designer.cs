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
        formHeader = new Label();
        apiLabel = new Label();
        apiText = new TextBox();
        callApi = new Button();
        resultsText = new TextBox();
        statusStrip = new StatusStrip();
        systemStatus = new ToolStripStatusLabel();
        resultsLabel = new Label();
        statusStrip.SuspendLayout();
        SuspendLayout();
        // 
        // formHeader
        // 
        formHeader.AutoSize = true;
        formHeader.Font = new Font("Segoe UI", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
        formHeader.Location = new Point(60, 24);
        formHeader.Name = "formHeader";
        formHeader.Size = new Size(254, 47);
        formHeader.TabIndex = 0;
        formHeader.Text = "Postman Clone";
        // 
        // apiLabel
        // 
        apiLabel.AutoSize = true;
        apiLabel.Location = new Point(58, 150);
        apiLabel.Name = "apiLabel";
        apiLabel.Size = new Size(53, 32);
        apiLabel.TabIndex = 1;
        apiLabel.Text = "API:";
        // 
        // apiText
        // 
        apiText.Location = new Point(117, 147);
        apiText.Name = "apiText";
        apiText.Size = new Size(841, 39);
        apiText.TabIndex = 2;
        // 
        // callApi
        // 
        callApi.Location = new Point(964, 147);
        callApi.Name = "callApi";
        callApi.Size = new Size(58, 39);
        callApi.TabIndex = 3;
        callApi.Text = "Go";
        callApi.UseVisualStyleBackColor = true;
        callApi.Click += callApi_Click;
        // 
        // resultsText
        // 
        resultsText.BackColor = Color.White;
        resultsText.Location = new Point(60, 258);
        resultsText.Multiline = true;
        resultsText.Name = "resultsText";
        resultsText.ReadOnly = true;
        resultsText.ScrollBars = ScrollBars.Both;
        resultsText.Size = new Size(962, 394);
        resultsText.TabIndex = 4;
        // 
        // statusStrip
        // 
        statusStrip.BackColor = Color.White;
        statusStrip.Items.AddRange(new ToolStripItem[] { systemStatus });
        statusStrip.Location = new Point(0, 674);
        statusStrip.Name = "statusStrip";
        statusStrip.Size = new Size(1075, 35);
        statusStrip.TabIndex = 5;
        statusStrip.Text = "System Status";
        // 
        // systemStatus
        // 
        systemStatus.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
        systemStatus.Name = "systemStatus";
        systemStatus.Size = new Size(69, 30);
        systemStatus.Text = "Ready";
        // 
        // resultsLabel
        // 
        resultsLabel.AutoSize = true;
        resultsLabel.Location = new Point(60, 223);
        resultsLabel.Name = "resultsLabel";
        resultsLabel.Size = new Size(93, 32);
        resultsLabel.TabIndex = 6;
        resultsLabel.Text = "Results:";
        // 
        // Dashboard
        // 
        AutoScaleDimensions = new SizeF(13F, 32F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.White;
        ClientSize = new Size(1075, 709);
        Controls.Add(resultsLabel);
        Controls.Add(statusStrip);
        Controls.Add(resultsText);
        Controls.Add(callApi);
        Controls.Add(apiText);
        Controls.Add(apiLabel);
        Controls.Add(formHeader);
        Font = new Font("Segoe UI", 18F);
        Margin = new Padding(6);
        Name = "Dashboard";
        Text = "Postman Clone by Zach Zak";
        Load += Dashboard_Load;
        statusStrip.ResumeLayout(false);
        statusStrip.PerformLayout();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Label formHeader;
    private Label apiLabel;
    private TextBox apiText;
    private Button callApi;
    private TextBox resultsText;
    private StatusStrip statusStrip;
    private Label resultsLabel;
    private ToolStripStatusLabel systemStatus;
}

namespace DAQMonitor.WinForms;

partial class MainForm
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
    private Button btnStart;
    private Button btnStop;
    private Label lblStatus;
    private Label lblFrame;
    /// <summary>
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        btnStart = new Button();
        btnStop = new Button();
        lblStatus = new Label();
        lblFrame = new Label();

        // Start 버튼
        btnStart.Text = "Start";
        btnStart.Location = new System.Drawing.Point(20, 20);
        btnStart.Size = new System.Drawing.Size(90, 40);   // ⬅ 크기 증가
        btnStart.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
        btnStart.Click += btnStart_Click;

        // Stop 버튼
        btnStop.Text = "Stop";
        btnStop.Location = new System.Drawing.Point(120, 20);
        btnStop.Size = new System.Drawing.Size(90, 40);    // ⬅ 크기 증가
        btnStop.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
        btnStop.Click += btnStop_Click;

        lblStatus.Text = "Idle";
        lblStatus.Location = new System.Drawing.Point(20, 80);
        lblStatus.AutoSize = true;

        lblFrame.Text = "No data";
        lblFrame.Location = new System.Drawing.Point(20, 110);
        lblFrame.AutoSize = true;

        Controls.Add(btnStart);
        Controls.Add(btnStop);
        Controls.Add(lblStatus);
        Controls.Add(lblFrame);

        Text = "DAQMonitor";
        ClientSize = new System.Drawing.Size(340, 180);
    }


    #endregion
}

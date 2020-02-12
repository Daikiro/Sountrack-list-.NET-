namespace Seminární_práce___soundtrack_list
{
    partial class Form1
    {
        /// <summary>
        /// Vyžaduje se proměnná návrháře.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Uvolněte všechny používané prostředky.
        /// </summary>
        /// <param name="disposing">hodnota true, když by se měl spravovaný prostředek odstranit; jinak false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kód generovaný Návrhářem Windows Form

        /// <summary>
        /// Metoda vyžadovaná pro podporu Návrháře - neupravovat
        /// obsah této metody v editoru kódu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.vytvořitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importovatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportovatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vybratToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.prvníListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.druhýListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.třetíListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.čtvrtýListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pátýListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.smazatCelýListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nápovědaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zobrazitNápověduToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oProgramuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oAutoroviToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nastaveníToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.anglickáVerzeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listBox_songy = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox_songy = new System.Windows.Forms.GroupBox();
            this.button_add = new System.Windows.Forms.Button();
            this.button_delete = new System.Windows.Forms.Button();
            this.listBox_soundtrack = new System.Windows.Forms.ListBox();
            this.groupBox_soundtrack = new System.Windows.Forms.GroupBox();
            this.button_down = new System.Windows.Forms.Button();
            this.button_up = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label_status_seznam = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label_time = new System.Windows.Forms.Label();
            this.button_next_step = new System.Windows.Forms.Button();
            this.label_helper = new System.Windows.Forms.Label();
            this.label_helper_text = new System.Windows.Forms.Label();
            this.groupBox_komponenty = new System.Windows.Forms.GroupBox();
            this.button_play = new System.Windows.Forms.Button();
            this.groupBox_play_menu = new System.Windows.Forms.GroupBox();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.label_time_play = new System.Windows.Forms.Label();
            this.label_seznam_play = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.button_next_play = new System.Windows.Forms.Button();
            this.button_back_play = new System.Windows.Forms.Button();
            this.button_stop_play = new System.Windows.Forms.Button();
            this.button_pause_play = new System.Windows.Forms.Button();
            this.button_play_play = new System.Windows.Forms.Button();
            this.label_next_song_play = new System.Windows.Forms.Label();
            this.label_actual_song_play = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.WMP = new AxWMPLib.AxWindowsMediaPlayer();
            this.timer_start = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            this.groupBox_songy.SuspendLayout();
            this.groupBox_soundtrack.SuspendLayout();
            this.groupBox_komponenty.SuspendLayout();
            this.groupBox_play_menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WMP)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.vytvořitToolStripMenuItem,
            this.vybratToolStripMenuItem,
            this.nápovědaToolStripMenuItem,
            this.nastaveníToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1094, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // vytvořitToolStripMenuItem
            // 
            this.vytvořitToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.importovatToolStripMenuItem,
            this.exportovatToolStripMenuItem});
            this.vytvořitToolStripMenuItem.Name = "vytvořitToolStripMenuItem";
            this.vytvořitToolStripMenuItem.Size = new System.Drawing.Size(69, 24);
            this.vytvořitToolStripMenuItem.Text = "Soubor";
            // 
            // importovatToolStripMenuItem
            // 
            this.importovatToolStripMenuItem.Name = "importovatToolStripMenuItem";
            this.importovatToolStripMenuItem.Size = new System.Drawing.Size(158, 26);
            this.importovatToolStripMenuItem.Text = "Importovat";
            this.importovatToolStripMenuItem.Click += new System.EventHandler(this.importovatToolStripMenuItem_Click);
            // 
            // exportovatToolStripMenuItem
            // 
            this.exportovatToolStripMenuItem.Name = "exportovatToolStripMenuItem";
            this.exportovatToolStripMenuItem.Size = new System.Drawing.Size(158, 26);
            this.exportovatToolStripMenuItem.Text = "Exportovat";
            this.exportovatToolStripMenuItem.Click += new System.EventHandler(this.exportovatToolStripMenuItem_Click);
            // 
            // vybratToolStripMenuItem
            // 
            this.vybratToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.prvníListToolStripMenuItem,
            this.druhýListToolStripMenuItem,
            this.třetíListToolStripMenuItem,
            this.čtvrtýListToolStripMenuItem,
            this.pátýListToolStripMenuItem,
            this.smazatCelýListToolStripMenuItem});
            this.vybratToolStripMenuItem.Name = "vybratToolStripMenuItem";
            this.vybratToolStripMenuItem.Size = new System.Drawing.Size(64, 24);
            this.vybratToolStripMenuItem.Text = "Vybrat";
            // 
            // prvníListToolStripMenuItem
            // 
            this.prvníListToolStripMenuItem.Name = "prvníListToolStripMenuItem";
            this.prvníListToolStripMenuItem.Size = new System.Drawing.Size(186, 26);
            this.prvníListToolStripMenuItem.Text = "První list";
            this.prvníListToolStripMenuItem.Click += new System.EventHandler(this.prvníListToolStripMenuItem_Click);
            // 
            // druhýListToolStripMenuItem
            // 
            this.druhýListToolStripMenuItem.Name = "druhýListToolStripMenuItem";
            this.druhýListToolStripMenuItem.Size = new System.Drawing.Size(186, 26);
            this.druhýListToolStripMenuItem.Text = "Druhý list";
            this.druhýListToolStripMenuItem.Click += new System.EventHandler(this.druhýListToolStripMenuItem_Click);
            // 
            // třetíListToolStripMenuItem
            // 
            this.třetíListToolStripMenuItem.Name = "třetíListToolStripMenuItem";
            this.třetíListToolStripMenuItem.Size = new System.Drawing.Size(186, 26);
            this.třetíListToolStripMenuItem.Text = "Třetí list";
            this.třetíListToolStripMenuItem.Click += new System.EventHandler(this.třetíListToolStripMenuItem_Click);
            // 
            // čtvrtýListToolStripMenuItem
            // 
            this.čtvrtýListToolStripMenuItem.Name = "čtvrtýListToolStripMenuItem";
            this.čtvrtýListToolStripMenuItem.Size = new System.Drawing.Size(186, 26);
            this.čtvrtýListToolStripMenuItem.Text = "Čtvrtý list";
            this.čtvrtýListToolStripMenuItem.Click += new System.EventHandler(this.čtvrtýListToolStripMenuItem_Click);
            // 
            // pátýListToolStripMenuItem
            // 
            this.pátýListToolStripMenuItem.Name = "pátýListToolStripMenuItem";
            this.pátýListToolStripMenuItem.Size = new System.Drawing.Size(186, 26);
            this.pátýListToolStripMenuItem.Text = "Pátý list";
            this.pátýListToolStripMenuItem.Click += new System.EventHandler(this.pátýListToolStripMenuItem_Click);
            // 
            // smazatCelýListToolStripMenuItem
            // 
            this.smazatCelýListToolStripMenuItem.Name = "smazatCelýListToolStripMenuItem";
            this.smazatCelýListToolStripMenuItem.Size = new System.Drawing.Size(186, 26);
            this.smazatCelýListToolStripMenuItem.Text = "Smazat celý list";
            this.smazatCelýListToolStripMenuItem.Click += new System.EventHandler(this.smazatCelýListToolStripMenuItem_Click);
            // 
            // nápovědaToolStripMenuItem
            // 
            this.nápovědaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.zobrazitNápověduToolStripMenuItem,
            this.oProgramuToolStripMenuItem,
            this.oAutoroviToolStripMenuItem});
            this.nápovědaToolStripMenuItem.Name = "nápovědaToolStripMenuItem";
            this.nápovědaToolStripMenuItem.Size = new System.Drawing.Size(90, 24);
            this.nápovědaToolStripMenuItem.Text = "Nápověda";
            // 
            // zobrazitNápověduToolStripMenuItem
            // 
            this.zobrazitNápověduToolStripMenuItem.Name = "zobrazitNápověduToolStripMenuItem";
            this.zobrazitNápověduToolStripMenuItem.Size = new System.Drawing.Size(210, 26);
            this.zobrazitNápověduToolStripMenuItem.Text = "Zobrazit nápovědu";
            this.zobrazitNápověduToolStripMenuItem.Click += new System.EventHandler(this.zobrazitNápověduToolStripMenuItem_Click);
            // 
            // oProgramuToolStripMenuItem
            // 
            this.oProgramuToolStripMenuItem.Name = "oProgramuToolStripMenuItem";
            this.oProgramuToolStripMenuItem.Size = new System.Drawing.Size(210, 26);
            this.oProgramuToolStripMenuItem.Text = "O programu";
            this.oProgramuToolStripMenuItem.Click += new System.EventHandler(this.oProgramuToolStripMenuItem_Click);
            // 
            // oAutoroviToolStripMenuItem
            // 
            this.oAutoroviToolStripMenuItem.Name = "oAutoroviToolStripMenuItem";
            this.oAutoroviToolStripMenuItem.Size = new System.Drawing.Size(210, 26);
            this.oAutoroviToolStripMenuItem.Text = "O autorovi";
            this.oAutoroviToolStripMenuItem.Click += new System.EventHandler(this.oAutoroviToolStripMenuItem_Click);
            // 
            // nastaveníToolStripMenuItem
            // 
            this.nastaveníToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.anglickáVerzeToolStripMenuItem});
            this.nastaveníToolStripMenuItem.Name = "nastaveníToolStripMenuItem";
            this.nastaveníToolStripMenuItem.Size = new System.Drawing.Size(86, 24);
            this.nastaveníToolStripMenuItem.Text = "Nastavení";
            // 
            // anglickáVerzeToolStripMenuItem
            // 
            this.anglickáVerzeToolStripMenuItem.Enabled = false;
            this.anglickáVerzeToolStripMenuItem.Name = "anglickáVerzeToolStripMenuItem";
            this.anglickáVerzeToolStripMenuItem.Size = new System.Drawing.Size(180, 26);
            this.anglickáVerzeToolStripMenuItem.Text = "Anglická verze";
            this.anglickáVerzeToolStripMenuItem.Click += new System.EventHandler(this.anglickáVerzeToolStripMenuItem_Click);
            // 
            // listBox_songy
            // 
            this.listBox_songy.FormattingEnabled = true;
            this.listBox_songy.ItemHeight = 16;
            this.listBox_songy.Location = new System.Drawing.Point(18, 82);
            this.listBox_songy.Name = "listBox_songy";
            this.listBox_songy.Size = new System.Drawing.Size(292, 132);
            this.listBox_songy.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(155, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Název";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Autor";
            // 
            // groupBox_songy
            // 
            this.groupBox_songy.Controls.Add(this.button_add);
            this.groupBox_songy.Controls.Add(this.label3);
            this.groupBox_songy.Controls.Add(this.listBox_songy);
            this.groupBox_songy.Controls.Add(this.label2);
            this.groupBox_songy.Location = new System.Drawing.Point(715, 80);
            this.groupBox_songy.Name = "groupBox_songy";
            this.groupBox_songy.Size = new System.Drawing.Size(354, 410);
            this.groupBox_songy.TabIndex = 5;
            this.groupBox_songy.TabStop = false;
            this.groupBox_songy.Text = "Songy";
            // 
            // button_add
            // 
            this.button_add.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_add.Location = new System.Drawing.Point(18, 324);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(292, 41);
            this.button_add.TabIndex = 5;
            this.button_add.Text = "Přidat";
            this.button_add.UseVisualStyleBackColor = true;
            this.button_add.Click += new System.EventHandler(this.button_add_Click);
            // 
            // button_delete
            // 
            this.button_delete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_delete.Location = new System.Drawing.Point(24, 324);
            this.button_delete.Name = "button_delete";
            this.button_delete.Size = new System.Drawing.Size(278, 41);
            this.button_delete.TabIndex = 6;
            this.button_delete.Text = "Odstranit";
            this.button_delete.UseVisualStyleBackColor = true;
            this.button_delete.Click += new System.EventHandler(this.button_delete_Click);
            // 
            // listBox_soundtrack
            // 
            this.listBox_soundtrack.FormattingEnabled = true;
            this.listBox_soundtrack.ItemHeight = 16;
            this.listBox_soundtrack.Location = new System.Drawing.Point(24, 82);
            this.listBox_soundtrack.Name = "listBox_soundtrack";
            this.listBox_soundtrack.Size = new System.Drawing.Size(278, 212);
            this.listBox_soundtrack.TabIndex = 6;
            // 
            // groupBox_soundtrack
            // 
            this.groupBox_soundtrack.Controls.Add(this.button_down);
            this.groupBox_soundtrack.Controls.Add(this.button_up);
            this.groupBox_soundtrack.Controls.Add(this.button_delete);
            this.groupBox_soundtrack.Controls.Add(this.label4);
            this.groupBox_soundtrack.Controls.Add(this.listBox_soundtrack);
            this.groupBox_soundtrack.Controls.Add(this.label1);
            this.groupBox_soundtrack.Location = new System.Drawing.Point(16, 80);
            this.groupBox_soundtrack.Name = "groupBox_soundtrack";
            this.groupBox_soundtrack.Size = new System.Drawing.Size(377, 410);
            this.groupBox_soundtrack.TabIndex = 8;
            this.groupBox_soundtrack.TabStop = false;
            this.groupBox_soundtrack.Text = "Soundtrack";
            // 
            // button_down
            // 
            this.button_down.BackgroundImage = global::Seminární_práce___soundtrack_list.Properties.Resources.DOWN;
            this.button_down.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_down.Enabled = false;
            this.button_down.FlatAppearance.BorderSize = 0;
            this.button_down.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_down.Location = new System.Drawing.Point(308, 182);
            this.button_down.Name = "button_down";
            this.button_down.Size = new System.Drawing.Size(55, 55);
            this.button_down.TabIndex = 7;
            this.button_down.UseVisualStyleBackColor = true;
            this.button_down.Click += new System.EventHandler(this.button_down_Click);
            // 
            // button_up
            // 
            this.button_up.BackgroundImage = global::Seminární_práce___soundtrack_list.Properties.Resources.UP;
            this.button_up.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_up.Enabled = false;
            this.button_up.FlatAppearance.BorderSize = 0;
            this.button_up.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_up.Location = new System.Drawing.Point(308, 91);
            this.button_up.Name = "button_up";
            this.button_up.Size = new System.Drawing.Size(55, 55);
            this.button_up.TabIndex = 7;
            this.button_up.UseVisualStyleBackColor = true;
            this.button_up.Click += new System.EventHandler(this.button_up_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Autor";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(161, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Název";
            // 
            // label_status_seznam
            // 
            this.label_status_seznam.AutoSize = true;
            this.label_status_seznam.Location = new System.Drawing.Point(27, 31);
            this.label_status_seznam.Name = "label_status_seznam";
            this.label_status_seznam.Size = new System.Drawing.Size(46, 17);
            this.label_status_seznam.TabIndex = 9;
            this.label_status_seznam.Text = "label1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 292);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Celková délka: ";
            // 
            // label_time
            // 
            this.label_time.AutoSize = true;
            this.label_time.Location = new System.Drawing.Point(125, 292);
            this.label_time.Name = "label_time";
            this.label_time.Size = new System.Drawing.Size(64, 17);
            this.label_time.TabIndex = 11;
            this.label_time.Text = "00:00:00";
            // 
            // button_next_step
            // 
            this.button_next_step.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button_next_step.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_next_step.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_next_step.Location = new System.Drawing.Point(441, 449);
            this.button_next_step.Name = "button_next_step";
            this.button_next_step.Size = new System.Drawing.Size(202, 41);
            this.button_next_step.TabIndex = 12;
            this.button_next_step.Text = "Další krok";
            this.button_next_step.UseVisualStyleBackColor = false;
            this.button_next_step.Visible = false;
            this.button_next_step.Click += new System.EventHandler(this.button_next_step_Click);
            // 
            // label_helper
            // 
            this.label_helper.AutoSize = true;
            this.label_helper.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_helper.Location = new System.Drawing.Point(11, 28);
            this.label_helper.Name = "label_helper";
            this.label_helper.Size = new System.Drawing.Size(99, 29);
            this.label_helper.TabIndex = 13;
            this.label_helper.Text = "Helper:";
            this.label_helper.Visible = false;
            // 
            // label_helper_text
            // 
            this.label_helper_text.AutoSize = true;
            this.label_helper_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_helper_text.Location = new System.Drawing.Point(116, 33);
            this.label_helper_text.Name = "label_helper_text";
            this.label_helper_text.Size = new System.Drawing.Size(60, 24);
            this.label_helper_text.TabIndex = 13;
            this.label_helper_text.Text = "label6";
            this.label_helper_text.Visible = false;
            // 
            // groupBox_komponenty
            // 
            this.groupBox_komponenty.Controls.Add(this.button_play);
            this.groupBox_komponenty.Controls.Add(this.label_status_seznam);
            this.groupBox_komponenty.Controls.Add(this.label5);
            this.groupBox_komponenty.Controls.Add(this.label_time);
            this.groupBox_komponenty.Location = new System.Drawing.Point(420, 80);
            this.groupBox_komponenty.Name = "groupBox_komponenty";
            this.groupBox_komponenty.Size = new System.Drawing.Size(256, 334);
            this.groupBox_komponenty.TabIndex = 14;
            this.groupBox_komponenty.TabStop = false;
            this.groupBox_komponenty.Text = "Komponenty";
            // 
            // button_play
            // 
            this.button_play.Enabled = false;
            this.button_play.FlatAppearance.BorderSize = 0;
            this.button_play.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_play.Image = global::Seminární_práce___soundtrack_list.Properties.Resources.PB;
            this.button_play.Location = new System.Drawing.Point(18, 60);
            this.button_play.Name = "button_play";
            this.button_play.Size = new System.Drawing.Size(205, 203);
            this.button_play.TabIndex = 7;
            this.button_play.UseVisualStyleBackColor = true;
            this.button_play.Click += new System.EventHandler(this.button_play_Click);
            // 
            // groupBox_play_menu
            // 
            this.groupBox_play_menu.Controls.Add(this.trackBar1);
            this.groupBox_play_menu.Controls.Add(this.label_time_play);
            this.groupBox_play_menu.Controls.Add(this.label_seznam_play);
            this.groupBox_play_menu.Controls.Add(this.label9);
            this.groupBox_play_menu.Controls.Add(this.label8);
            this.groupBox_play_menu.Controls.Add(this.button_next_play);
            this.groupBox_play_menu.Controls.Add(this.button_back_play);
            this.groupBox_play_menu.Controls.Add(this.button_stop_play);
            this.groupBox_play_menu.Controls.Add(this.button_pause_play);
            this.groupBox_play_menu.Controls.Add(this.button_play_play);
            this.groupBox_play_menu.Controls.Add(this.label_next_song_play);
            this.groupBox_play_menu.Controls.Add(this.label_actual_song_play);
            this.groupBox_play_menu.Controls.Add(this.label7);
            this.groupBox_play_menu.Controls.Add(this.label6);
            this.groupBox_play_menu.Enabled = false;
            this.groupBox_play_menu.Location = new System.Drawing.Point(16, 513);
            this.groupBox_play_menu.Name = "groupBox_play_menu";
            this.groupBox_play_menu.Size = new System.Drawing.Size(1053, 81);
            this.groupBox_play_menu.TabIndex = 15;
            this.groupBox_play_menu.TabStop = false;
            this.groupBox_play_menu.Text = "Play menu";
            // 
            // trackBar1
            // 
            this.trackBar1.LargeChange = 3;
            this.trackBar1.Location = new System.Drawing.Point(532, 21);
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(144, 56);
            this.trackBar1.SmallChange = 2;
            this.trackBar1.TabIndex = 13;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // label_time_play
            // 
            this.label_time_play.AutoSize = true;
            this.label_time_play.Location = new System.Drawing.Point(434, 26);
            this.label_time_play.Name = "label_time_play";
            this.label_time_play.Size = new System.Drawing.Size(64, 17);
            this.label_time_play.TabIndex = 12;
            this.label_time_play.Text = "00:00:00";
            // 
            // label_seznam_play
            // 
            this.label_seznam_play.AutoSize = true;
            this.label_seznam_play.Location = new System.Drawing.Point(434, 59);
            this.label_seznam_play.Name = "label_seznam_play";
            this.label_seznam_play.Size = new System.Drawing.Size(54, 17);
            this.label_seznam_play.TabIndex = 11;
            this.label_seznam_play.Text = "label10";
            this.label_seznam_play.TextChanged += new System.EventHandler(this.label_seznam_play_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(371, 59);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(46, 17);
            this.label9.TabIndex = 10;
            this.label9.Text = "Hraje:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(368, 26);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(36, 17);
            this.label8.TabIndex = 9;
            this.label8.Text = "Čas:";
            // 
            // button_next_play
            // 
            this.button_next_play.BackgroundImage = global::Seminární_práce___soundtrack_list.Properties.Resources.next;
            this.button_next_play.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_next_play.FlatAppearance.BorderSize = 0;
            this.button_next_play.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_next_play.Location = new System.Drawing.Point(1000, 26);
            this.button_next_play.Name = "button_next_play";
            this.button_next_play.Size = new System.Drawing.Size(51, 51);
            this.button_next_play.TabIndex = 8;
            this.button_next_play.UseVisualStyleBackColor = true;
            this.button_next_play.Click += new System.EventHandler(this.button_next_play_Click);
            // 
            // button_back_play
            // 
            this.button_back_play.BackgroundImage = global::Seminární_práce___soundtrack_list.Properties.Resources.back;
            this.button_back_play.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_back_play.Enabled = false;
            this.button_back_play.FlatAppearance.BorderSize = 0;
            this.button_back_play.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_back_play.Location = new System.Drawing.Point(925, 26);
            this.button_back_play.Name = "button_back_play";
            this.button_back_play.Size = new System.Drawing.Size(51, 51);
            this.button_back_play.TabIndex = 7;
            this.button_back_play.UseVisualStyleBackColor = true;
            this.button_back_play.Click += new System.EventHandler(this.button_back_play_Click);
            // 
            // button_stop_play
            // 
            this.button_stop_play.BackgroundImage = global::Seminární_práce___soundtrack_list.Properties.Resources.stop;
            this.button_stop_play.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_stop_play.FlatAppearance.BorderSize = 0;
            this.button_stop_play.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_stop_play.Location = new System.Drawing.Point(850, 26);
            this.button_stop_play.Name = "button_stop_play";
            this.button_stop_play.Size = new System.Drawing.Size(51, 51);
            this.button_stop_play.TabIndex = 6;
            this.button_stop_play.UseVisualStyleBackColor = true;
            this.button_stop_play.Click += new System.EventHandler(this.button_stop_play_Click);
            // 
            // button_pause_play
            // 
            this.button_pause_play.BackgroundImage = global::Seminární_práce___soundtrack_list.Properties.Resources.pause;
            this.button_pause_play.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_pause_play.FlatAppearance.BorderSize = 0;
            this.button_pause_play.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_pause_play.Location = new System.Drawing.Point(775, 26);
            this.button_pause_play.Name = "button_pause_play";
            this.button_pause_play.Size = new System.Drawing.Size(51, 51);
            this.button_pause_play.TabIndex = 5;
            this.button_pause_play.UseVisualStyleBackColor = true;
            this.button_pause_play.Click += new System.EventHandler(this.button_pause_play_Click);
            // 
            // button_play_play
            // 
            this.button_play_play.BackgroundImage = global::Seminární_práce___soundtrack_list.Properties.Resources.play;
            this.button_play_play.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_play_play.FlatAppearance.BorderSize = 0;
            this.button_play_play.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_play_play.Location = new System.Drawing.Point(700, 26);
            this.button_play_play.Name = "button_play_play";
            this.button_play_play.Size = new System.Drawing.Size(51, 51);
            this.button_play_play.TabIndex = 4;
            this.button_play_play.UseVisualStyleBackColor = true;
            this.button_play_play.Click += new System.EventHandler(this.button_play_play_Click);
            // 
            // label_next_song_play
            // 
            this.label_next_song_play.AutoSize = true;
            this.label_next_song_play.Location = new System.Drawing.Point(140, 60);
            this.label_next_song_play.Name = "label_next_song_play";
            this.label_next_song_play.Size = new System.Drawing.Size(206, 17);
            this.label_next_song_play.TabIndex = 3;
            this.label_next_song_play.Text = "Iron maiden\", \"Run To The Hills";
            // 
            // label_actual_song_play
            // 
            this.label_actual_song_play.AutoSize = true;
            this.label_actual_song_play.Location = new System.Drawing.Point(140, 26);
            this.label_actual_song_play.Name = "label_actual_song_play";
            this.label_actual_song_play.Size = new System.Drawing.Size(46, 17);
            this.label_actual_song_play.TabIndex = 2;
            this.label_actual_song_play.Text = "label8";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 60);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(115, 17);
            this.label7.TabIndex = 1;
            this.label7.Text = "Následující song:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 17);
            this.label6.TabIndex = 0;
            this.label6.Text = "Aktuální song:";
            // 
            // WMP
            // 
            this.WMP.Enabled = true;
            this.WMP.Location = new System.Drawing.Point(438, 621);
            this.WMP.Name = "WMP";
            this.WMP.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("WMP.OcxState")));
            this.WMP.Size = new System.Drawing.Size(75, 23);
            this.WMP.TabIndex = 16;
            this.WMP.Visible = false;
            // 
            // timer_start
            // 
            this.timer_start.Interval = 1000;
            this.timer_start.Tick += new System.EventHandler(this.timer_start_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1094, 602);
            this.Controls.Add(this.WMP);
            this.Controls.Add(this.groupBox_play_menu);
            this.Controls.Add(this.groupBox_komponenty);
            this.Controls.Add(this.label_helper_text);
            this.Controls.Add(this.label_helper);
            this.Controls.Add(this.button_next_step);
            this.Controls.Add(this.groupBox_soundtrack);
            this.Controls.Add(this.groupBox_songy);
            this.Controls.Add(this.menuStrip1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Soundtrack creator";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox_songy.ResumeLayout(false);
            this.groupBox_songy.PerformLayout();
            this.groupBox_soundtrack.ResumeLayout(false);
            this.groupBox_soundtrack.PerformLayout();
            this.groupBox_komponenty.ResumeLayout(false);
            this.groupBox_komponenty.PerformLayout();
            this.groupBox_play_menu.ResumeLayout(false);
            this.groupBox_play_menu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WMP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem vytvořitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importovatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportovatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vybratToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem prvníListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem druhýListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem třetíListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem čtvrtýListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pátýListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nápovědaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zobrazitNápověduToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem oProgramuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem oAutoroviToolStripMenuItem;
        private System.Windows.Forms.ListBox listBox_songy;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox_songy;
        private System.Windows.Forms.Button button_delete;
        private System.Windows.Forms.Button button_add;
        private System.Windows.Forms.ListBox listBox_soundtrack;
        private System.Windows.Forms.GroupBox groupBox_soundtrack;
        private System.Windows.Forms.Label label_status_seznam;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem smazatCelýListToolStripMenuItem;
        private System.Windows.Forms.Button button_down;
        private System.Windows.Forms.Button button_up;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label_time;
        private System.Windows.Forms.Button button_next_step;
        private System.Windows.Forms.Label label_helper;
        private System.Windows.Forms.Label label_helper_text;
        private System.Windows.Forms.GroupBox groupBox_komponenty;
        private System.Windows.Forms.Button button_play;
        private System.Windows.Forms.GroupBox groupBox_play_menu;
        private System.Windows.Forms.Button button_next_play;
        private System.Windows.Forms.Button button_back_play;
        private System.Windows.Forms.Button button_stop_play;
        private System.Windows.Forms.Button button_pause_play;
        private System.Windows.Forms.Button button_play_play;
        private System.Windows.Forms.Label label_next_song_play;
        private System.Windows.Forms.Label label_actual_song_play;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label_time_play;
        private System.Windows.Forms.Label label_seznam_play;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TrackBar trackBar1;
        private AxWMPLib.AxWindowsMediaPlayer WMP;
        private System.Windows.Forms.Timer timer_start;
        private System.Windows.Forms.ToolStripMenuItem nastaveníToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem anglickáVerzeToolStripMenuItem;
    }
}


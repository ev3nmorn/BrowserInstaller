namespace BrowserInstaller
{
    partial class mainFrom
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.downloadFirefoxBlock = new System.Windows.Forms.GroupBox();
            this.downloadLabel = new System.Windows.Forms.Label();
            this.downloadButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.settingsBox = new System.Windows.Forms.GroupBox();
            this.privateModeCheckBox = new System.Windows.Forms.CheckBox();
            this.telemetryCheckBox = new System.Windows.Forms.CheckBox();
            this.updateAppCheckBox = new System.Windows.Forms.CheckBox();
            this.aboutSupportCheckBox = new System.Windows.Forms.CheckBox();
            this.aboutProfilesCheckBox = new System.Windows.Forms.CheckBox();
            this.aboutConfigCheckBox = new System.Windows.Forms.CheckBox();
            this.aboutAddonsCheckBox = new System.Windows.Forms.CheckBox();
            this.proxyBox = new System.Windows.Forms.GroupBox();
            this.portProxyLabel = new System.Windows.Forms.Label();
            this.portProxy = new System.Windows.Forms.TextBox();
            this.ipProxyLabel = new System.Windows.Forms.Label();
            this.ipProxy4 = new System.Windows.Forms.TextBox();
            this.ipProxy1 = new System.Windows.Forms.TextBox();
            this.ipProxy3 = new System.Windows.Forms.TextBox();
            this.lockedProxyCheckBox = new System.Windows.Forms.CheckBox();
            this.ipProxy2 = new System.Windows.Forms.TextBox();
            this.enableProxyCheckBox = new System.Windows.Forms.CheckBox();
            this.possibleAddonsListBox = new System.Windows.Forms.ListBox();
            this.addonsBox = new System.Windows.Forms.GroupBox();
            this.addonToInstallLabel = new System.Windows.Forms.Label();
            this.possibleAddonsLabel = new System.Windows.Forms.Label();
            this.offlineButton = new System.Windows.Forms.RadioButton();
            this.addonsToInstallListbox = new System.Windows.Forms.ListBox();
            this.onlineButton = new System.Windows.Forms.RadioButton();
            this.searchAddonButton = new System.Windows.Forms.Button();
            this.searchAddonTextBox = new System.Windows.Forms.TextBox();
            this.installButton = new System.Windows.Forms.Button();
            this.configAlreadyExists = new System.Windows.Forms.CheckBox();
            this.savePasswordsCheckBox = new System.Windows.Forms.CheckBox();
            this.downloadFirefoxBlock.SuspendLayout();
            this.settingsBox.SuspendLayout();
            this.proxyBox.SuspendLayout();
            this.addonsBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // downloadFirefoxBlock
            // 
            this.downloadFirefoxBlock.Controls.Add(this.downloadLabel);
            this.downloadFirefoxBlock.Controls.Add(this.downloadButton);
            this.downloadFirefoxBlock.Location = new System.Drawing.Point(12, 12);
            this.downloadFirefoxBlock.Name = "downloadFirefoxBlock";
            this.downloadFirefoxBlock.Size = new System.Drawing.Size(216, 86);
            this.downloadFirefoxBlock.TabIndex = 0;
            this.downloadFirefoxBlock.TabStop = false;
            this.downloadFirefoxBlock.Text = "Скачать инсталлятор";
            // 
            // downloadLabel
            // 
            this.downloadLabel.AutoSize = true;
            this.downloadLabel.Location = new System.Drawing.Point(6, 21);
            this.downloadLabel.MaximumSize = new System.Drawing.Size(135, 0);
            this.downloadLabel.Name = "downloadLabel";
            this.downloadLabel.Size = new System.Drawing.Size(124, 52);
            this.downloadLabel.TabIndex = 1;
            this.downloadLabel.Text = "Переместите инсталлятор в папку с программой или скачайте его";
            // 
            // downloadButton
            // 
            this.downloadButton.Location = new System.Drawing.Point(135, 35);
            this.downloadButton.Name = "downloadButton";
            this.downloadButton.Size = new System.Drawing.Size(75, 23);
            this.downloadButton.TabIndex = 0;
            this.downloadButton.Text = "Скачать";
            this.downloadButton.UseVisualStyleBackColor = true;
            this.downloadButton.Click += new System.EventHandler(this.downloadButton_Click);
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(573, 340);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(75, 23);
            this.closeButton.TabIndex = 1;
            this.closeButton.Text = "Закрыть";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // settingsBox
            // 
            this.settingsBox.Controls.Add(this.savePasswordsCheckBox);
            this.settingsBox.Controls.Add(this.privateModeCheckBox);
            this.settingsBox.Controls.Add(this.telemetryCheckBox);
            this.settingsBox.Controls.Add(this.updateAppCheckBox);
            this.settingsBox.Controls.Add(this.aboutSupportCheckBox);
            this.settingsBox.Controls.Add(this.aboutProfilesCheckBox);
            this.settingsBox.Controls.Add(this.aboutConfigCheckBox);
            this.settingsBox.Controls.Add(this.aboutAddonsCheckBox);
            this.settingsBox.Location = new System.Drawing.Point(12, 104);
            this.settingsBox.Name = "settingsBox";
            this.settingsBox.Size = new System.Drawing.Size(216, 234);
            this.settingsBox.TabIndex = 2;
            this.settingsBox.TabStop = false;
            this.settingsBox.Text = "Настройки браузера";
            // 
            // privateModeCheckBox
            // 
            this.privateModeCheckBox.AutoSize = true;
            this.privateModeCheckBox.Location = new System.Drawing.Point(6, 168);
            this.privateModeCheckBox.Name = "privateModeCheckBox";
            this.privateModeCheckBox.Size = new System.Drawing.Size(173, 17);
            this.privateModeCheckBox.TabIndex = 6;
            this.privateModeCheckBox.Text = "Отключить режим инкогнито";
            this.privateModeCheckBox.UseVisualStyleBackColor = true;
            // 
            // telemetryCheckBox
            // 
            this.telemetryCheckBox.AutoSize = true;
            this.telemetryCheckBox.Location = new System.Drawing.Point(6, 144);
            this.telemetryCheckBox.Name = "telemetryCheckBox";
            this.telemetryCheckBox.Size = new System.Drawing.Size(193, 17);
            this.telemetryCheckBox.TabIndex = 5;
            this.telemetryCheckBox.Text = "Отключить отправку телеметрии";
            this.telemetryCheckBox.UseVisualStyleBackColor = true;
            // 
            // updateAppCheckBox
            // 
            this.updateAppCheckBox.AutoSize = true;
            this.updateAppCheckBox.Location = new System.Drawing.Point(6, 120);
            this.updateAppCheckBox.Name = "updateAppCheckBox";
            this.updateAppCheckBox.Size = new System.Drawing.Size(194, 17);
            this.updateAppCheckBox.TabIndex = 4;
            this.updateAppCheckBox.Text = "Отключить обновление браузера";
            this.updateAppCheckBox.UseVisualStyleBackColor = true;
            // 
            // aboutSupportCheckBox
            // 
            this.aboutSupportCheckBox.AutoSize = true;
            this.aboutSupportCheckBox.Location = new System.Drawing.Point(6, 96);
            this.aboutSupportCheckBox.Name = "aboutSupportCheckBox";
            this.aboutSupportCheckBox.Size = new System.Drawing.Size(193, 17);
            this.aboutSupportCheckBox.TabIndex = 3;
            this.aboutSupportCheckBox.Text = "Запретить доступ к about:support";
            this.aboutSupportCheckBox.UseVisualStyleBackColor = true;
            // 
            // aboutProfilesCheckBox
            // 
            this.aboutProfilesCheckBox.AutoSize = true;
            this.aboutProfilesCheckBox.Location = new System.Drawing.Point(6, 72);
            this.aboutProfilesCheckBox.Name = "aboutProfilesCheckBox";
            this.aboutProfilesCheckBox.Size = new System.Drawing.Size(191, 17);
            this.aboutProfilesCheckBox.TabIndex = 2;
            this.aboutProfilesCheckBox.Text = "Запретить доступ к about:profiles";
            this.aboutProfilesCheckBox.UseVisualStyleBackColor = true;
            // 
            // aboutConfigCheckBox
            // 
            this.aboutConfigCheckBox.AutoSize = true;
            this.aboutConfigCheckBox.Location = new System.Drawing.Point(6, 48);
            this.aboutConfigCheckBox.Name = "aboutConfigCheckBox";
            this.aboutConfigCheckBox.Size = new System.Drawing.Size(187, 17);
            this.aboutConfigCheckBox.TabIndex = 1;
            this.aboutConfigCheckBox.Text = "Запретить доступ к about:config";
            this.aboutConfigCheckBox.UseVisualStyleBackColor = true;
            // 
            // aboutAddonsCheckBox
            // 
            this.aboutAddonsCheckBox.AutoSize = true;
            this.aboutAddonsCheckBox.Location = new System.Drawing.Point(6, 24);
            this.aboutAddonsCheckBox.Name = "aboutAddonsCheckBox";
            this.aboutAddonsCheckBox.Size = new System.Drawing.Size(193, 17);
            this.aboutAddonsCheckBox.TabIndex = 0;
            this.aboutAddonsCheckBox.Text = "Запретить доступ к about:addons";
            this.aboutAddonsCheckBox.UseVisualStyleBackColor = true;
            // 
            // proxyBox
            // 
            this.proxyBox.Controls.Add(this.portProxyLabel);
            this.proxyBox.Controls.Add(this.portProxy);
            this.proxyBox.Controls.Add(this.ipProxyLabel);
            this.proxyBox.Controls.Add(this.ipProxy4);
            this.proxyBox.Controls.Add(this.ipProxy1);
            this.proxyBox.Controls.Add(this.ipProxy3);
            this.proxyBox.Controls.Add(this.lockedProxyCheckBox);
            this.proxyBox.Controls.Add(this.ipProxy2);
            this.proxyBox.Controls.Add(this.enableProxyCheckBox);
            this.proxyBox.Location = new System.Drawing.Point(235, 12);
            this.proxyBox.Name = "proxyBox";
            this.proxyBox.Size = new System.Drawing.Size(413, 86);
            this.proxyBox.TabIndex = 3;
            this.proxyBox.TabStop = false;
            this.proxyBox.Text = "Настройки прокси";
            // 
            // portProxyLabel
            // 
            this.portProxyLabel.AutoSize = true;
            this.portProxyLabel.Location = new System.Drawing.Point(324, 55);
            this.portProxyLabel.Name = "portProxyLabel";
            this.portProxyLabel.Size = new System.Drawing.Size(32, 13);
            this.portProxyLabel.TabIndex = 9;
            this.portProxyLabel.Text = "Порт";
            // 
            // portProxy
            // 
            this.portProxy.Location = new System.Drawing.Point(277, 52);
            this.portProxy.Name = "portProxy";
            this.portProxy.Size = new System.Drawing.Size(41, 20);
            this.portProxy.TabIndex = 8;
            // 
            // ipProxyLabel
            // 
            this.ipProxyLabel.AutoSize = true;
            this.ipProxyLabel.Location = new System.Drawing.Point(168, 56);
            this.ipProxyLabel.Name = "ipProxyLabel";
            this.ipProxyLabel.Size = new System.Drawing.Size(89, 13);
            this.ipProxyLabel.TabIndex = 7;
            this.ipProxyLabel.Text = "IP-адрес прокси";
            // 
            // ipProxy4
            // 
            this.ipProxy4.Location = new System.Drawing.Point(128, 53);
            this.ipProxy4.Name = "ipProxy4";
            this.ipProxy4.Size = new System.Drawing.Size(34, 20);
            this.ipProxy4.TabIndex = 6;
            // 
            // ipProxy1
            // 
            this.ipProxy1.Location = new System.Drawing.Point(7, 53);
            this.ipProxy1.Name = "ipProxy1";
            this.ipProxy1.Size = new System.Drawing.Size(34, 20);
            this.ipProxy1.TabIndex = 2;
            // 
            // ipProxy3
            // 
            this.ipProxy3.Location = new System.Drawing.Point(88, 53);
            this.ipProxy3.Name = "ipProxy3";
            this.ipProxy3.Size = new System.Drawing.Size(34, 20);
            this.ipProxy3.TabIndex = 5;
            // 
            // lockedProxyCheckBox
            // 
            this.lockedProxyCheckBox.AutoSize = true;
            this.lockedProxyCheckBox.Location = new System.Drawing.Point(151, 19);
            this.lockedProxyCheckBox.Name = "lockedProxyCheckBox";
            this.lockedProxyCheckBox.Size = new System.Drawing.Size(257, 17);
            this.lockedProxyCheckBox.TabIndex = 1;
            this.lockedProxyCheckBox.Text = "Отключить настройку прокси пользователям";
            this.lockedProxyCheckBox.UseVisualStyleBackColor = true;
            // 
            // ipProxy2
            // 
            this.ipProxy2.Location = new System.Drawing.Point(48, 53);
            this.ipProxy2.Name = "ipProxy2";
            this.ipProxy2.Size = new System.Drawing.Size(34, 20);
            this.ipProxy2.TabIndex = 4;
            // 
            // enableProxyCheckBox
            // 
            this.enableProxyCheckBox.AutoSize = true;
            this.enableProxyCheckBox.Location = new System.Drawing.Point(6, 19);
            this.enableProxyCheckBox.Name = "enableProxyCheckBox";
            this.enableProxyCheckBox.Size = new System.Drawing.Size(138, 17);
            this.enableProxyCheckBox.TabIndex = 0;
            this.enableProxyCheckBox.Text = "Использовать прокси";
            this.enableProxyCheckBox.UseVisualStyleBackColor = true;
            this.enableProxyCheckBox.CheckedChanged += new System.EventHandler(this.enableProxyCheckBox_CheckedChanged);
            // 
            // possibleAddonsListBox
            // 
            this.possibleAddonsListBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.possibleAddonsListBox.FormattingEnabled = true;
            this.possibleAddonsListBox.Location = new System.Drawing.Point(6, 79);
            this.possibleAddonsListBox.Name = "possibleAddonsListBox";
            this.possibleAddonsListBox.Size = new System.Drawing.Size(194, 147);
            this.possibleAddonsListBox.TabIndex = 4;
            this.possibleAddonsListBox.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.possibleAddonsListBox_DrawItem);
            this.possibleAddonsListBox.MeasureItem += new System.Windows.Forms.MeasureItemEventHandler(this.possibleAddonsListBox_MeasureItem);
            this.possibleAddonsListBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.possibleAddonsListBox_MouseDown);
            // 
            // addonsBox
            // 
            this.addonsBox.Controls.Add(this.addonToInstallLabel);
            this.addonsBox.Controls.Add(this.possibleAddonsLabel);
            this.addonsBox.Controls.Add(this.offlineButton);
            this.addonsBox.Controls.Add(this.addonsToInstallListbox);
            this.addonsBox.Controls.Add(this.onlineButton);
            this.addonsBox.Controls.Add(this.searchAddonButton);
            this.addonsBox.Controls.Add(this.searchAddonTextBox);
            this.addonsBox.Controls.Add(this.possibleAddonsListBox);
            this.addonsBox.Location = new System.Drawing.Point(235, 105);
            this.addonsBox.Name = "addonsBox";
            this.addonsBox.Size = new System.Drawing.Size(413, 233);
            this.addonsBox.TabIndex = 5;
            this.addonsBox.TabStop = false;
            this.addonsBox.Text = "Установка дополнений";
            // 
            // addonToInstallLabel
            // 
            this.addonToInstallLabel.AutoSize = true;
            this.addonToInstallLabel.Location = new System.Drawing.Point(211, 63);
            this.addonToInstallLabel.Name = "addonToInstallLabel";
            this.addonToInstallLabel.Size = new System.Drawing.Size(149, 13);
            this.addonToInstallLabel.TabIndex = 9;
            this.addonToInstallLabel.Text = "Дополнения для установки:";
            // 
            // possibleAddonsLabel
            // 
            this.possibleAddonsLabel.AutoSize = true;
            this.possibleAddonsLabel.Location = new System.Drawing.Point(4, 63);
            this.possibleAddonsLabel.Name = "possibleAddonsLabel";
            this.possibleAddonsLabel.Size = new System.Drawing.Size(134, 13);
            this.possibleAddonsLabel.TabIndex = 8;
            this.possibleAddonsLabel.Text = "Возможные дополнения:";
            // 
            // offlineButton
            // 
            this.offlineButton.AutoSize = true;
            this.offlineButton.Location = new System.Drawing.Point(6, 40);
            this.offlineButton.Name = "offlineButton";
            this.offlineButton.Size = new System.Drawing.Size(65, 17);
            this.offlineButton.TabIndex = 7;
            this.offlineButton.TabStop = true;
            this.offlineButton.Text = "Офлайн";
            this.offlineButton.UseVisualStyleBackColor = true;
            this.offlineButton.CheckedChanged += new System.EventHandler(this.offlineButton_CheckedChanged);
            // 
            // addonsToInstallListbox
            // 
            this.addonsToInstallListbox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.addonsToInstallListbox.FormattingEnabled = true;
            this.addonsToInstallListbox.Location = new System.Drawing.Point(214, 79);
            this.addonsToInstallListbox.Name = "addonsToInstallListbox";
            this.addonsToInstallListbox.Size = new System.Drawing.Size(194, 147);
            this.addonsToInstallListbox.TabIndex = 7;
            this.addonsToInstallListbox.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.addonsToInstallListbox_DrawItem);
            this.addonsToInstallListbox.MeasureItem += new System.Windows.Forms.MeasureItemEventHandler(this.addonsToInstallListbox_MeasureItem);
            this.addonsToInstallListbox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.addonsToInstallListbox_MouseDown);
            // 
            // onlineButton
            // 
            this.onlineButton.AutoSize = true;
            this.onlineButton.Location = new System.Drawing.Point(77, 40);
            this.onlineButton.Name = "onlineButton";
            this.onlineButton.Size = new System.Drawing.Size(63, 17);
            this.onlineButton.TabIndex = 6;
            this.onlineButton.TabStop = true;
            this.onlineButton.Text = "Онлайн";
            this.onlineButton.UseVisualStyleBackColor = true;
            this.onlineButton.CheckedChanged += new System.EventHandler(this.onlineButton_CheckedChanged);
            // 
            // searchAddonButton
            // 
            this.searchAddonButton.Location = new System.Drawing.Point(262, 17);
            this.searchAddonButton.Name = "searchAddonButton";
            this.searchAddonButton.Size = new System.Drawing.Size(75, 23);
            this.searchAddonButton.TabIndex = 6;
            this.searchAddonButton.Text = "Найти";
            this.searchAddonButton.UseVisualStyleBackColor = true;
            this.searchAddonButton.Click += new System.EventHandler(this.searchAddonButton_Click);
            // 
            // searchAddonTextBox
            // 
            this.searchAddonTextBox.Location = new System.Drawing.Point(7, 19);
            this.searchAddonTextBox.Name = "searchAddonTextBox";
            this.searchAddonTextBox.Size = new System.Drawing.Size(249, 20);
            this.searchAddonTextBox.TabIndex = 5;
            // 
            // installButton
            // 
            this.installButton.Location = new System.Drawing.Point(492, 340);
            this.installButton.Name = "installButton";
            this.installButton.Size = new System.Drawing.Size(75, 23);
            this.installButton.TabIndex = 6;
            this.installButton.Text = "Установить";
            this.installButton.UseVisualStyleBackColor = true;
            this.installButton.Click += new System.EventHandler(this.installButton_Click);
            // 
            // configAlreadyExists
            // 
            this.configAlreadyExists.AutoSize = true;
            this.configAlreadyExists.Location = new System.Drawing.Point(12, 344);
            this.configAlreadyExists.Name = "configAlreadyExists";
            this.configAlreadyExists.Size = new System.Drawing.Size(242, 17);
            this.configAlreadyExists.TabIndex = 7;
            this.configAlreadyExists.Text = "Применить существующий файл настроек";
            this.configAlreadyExists.UseVisualStyleBackColor = true;
            this.configAlreadyExists.CheckedChanged += new System.EventHandler(this.configAlreadyExists_CheckedChanged);
            // 
            // savePasswordsCheckBox
            // 
            this.savePasswordsCheckBox.AutoSize = true;
            this.savePasswordsCheckBox.Location = new System.Drawing.Point(6, 191);
            this.savePasswordsCheckBox.Name = "savePasswordsCheckBox";
            this.savePasswordsCheckBox.Size = new System.Drawing.Size(188, 17);
            this.savePasswordsCheckBox.TabIndex = 7;
            this.savePasswordsCheckBox.Text = "Отключить сохранение паролей";
            this.savePasswordsCheckBox.UseVisualStyleBackColor = true;
            // 
            // mainFrom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(660, 368);
            this.Controls.Add(this.configAlreadyExists);
            this.Controls.Add(this.installButton);
            this.Controls.Add(this.addonsBox);
            this.Controls.Add(this.proxyBox);
            this.Controls.Add(this.settingsBox);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.downloadFirefoxBlock);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "mainFrom";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Установка браузера";
            this.downloadFirefoxBlock.ResumeLayout(false);
            this.downloadFirefoxBlock.PerformLayout();
            this.settingsBox.ResumeLayout(false);
            this.settingsBox.PerformLayout();
            this.proxyBox.ResumeLayout(false);
            this.proxyBox.PerformLayout();
            this.addonsBox.ResumeLayout(false);
            this.addonsBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox downloadFirefoxBlock;
        private System.Windows.Forms.Label downloadLabel;
        private System.Windows.Forms.Button downloadButton;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.GroupBox settingsBox;
        private System.Windows.Forms.CheckBox aboutAddonsCheckBox;
        private System.Windows.Forms.CheckBox aboutConfigCheckBox;
        private System.Windows.Forms.CheckBox aboutProfilesCheckBox;
        private System.Windows.Forms.CheckBox privateModeCheckBox;
        private System.Windows.Forms.CheckBox telemetryCheckBox;
        private System.Windows.Forms.CheckBox updateAppCheckBox;
        private System.Windows.Forms.CheckBox aboutSupportCheckBox;
        private System.Windows.Forms.GroupBox proxyBox;
        private System.Windows.Forms.CheckBox lockedProxyCheckBox;
        private System.Windows.Forms.CheckBox enableProxyCheckBox;
        private System.Windows.Forms.TextBox ipProxy1;
        private System.Windows.Forms.TextBox ipProxy2;
        private System.Windows.Forms.Label portProxyLabel;
        private System.Windows.Forms.TextBox portProxy;
        private System.Windows.Forms.Label ipProxyLabel;
        private System.Windows.Forms.TextBox ipProxy4;
        private System.Windows.Forms.TextBox ipProxy3;
        private System.Windows.Forms.ListBox possibleAddonsListBox;
        private System.Windows.Forms.GroupBox addonsBox;
        private System.Windows.Forms.Button searchAddonButton;
        private System.Windows.Forms.TextBox searchAddonTextBox;
        private System.Windows.Forms.ListBox addonsToInstallListbox;
        private System.Windows.Forms.RadioButton onlineButton;
        private System.Windows.Forms.RadioButton offlineButton;
        private System.Windows.Forms.Label possibleAddonsLabel;
        private System.Windows.Forms.Label addonToInstallLabel;
        private System.Windows.Forms.Button installButton;
        private System.Windows.Forms.CheckBox configAlreadyExists;
        private System.Windows.Forms.CheckBox savePasswordsCheckBox;
    }
}


namespace TreeCMS.Forms
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.menuStripMain = new System.Windows.Forms.MenuStrip();
            this.menuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.menuOpenStorage = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.menuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.menuTree = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAddRoot = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAddChild = new System.Windows.Forms.ToolStripMenuItem();
            this.menuRenameNode = new System.Windows.Forms.ToolStripMenuItem();
            this.menuDeleteNode = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.menuExpandAll = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCollapseAll = new System.Windows.Forms.ToolStripMenuItem();
            this.menuHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAbout = new System.Windows.Forms.ToolStripMenuItem();

            this.statusStripMain = new System.Windows.Forms.StatusStrip();
            this.statusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusNodeCount = new System.Windows.Forms.ToolStripStatusLabel();

            this.splitContainerMain = new System.Windows.Forms.SplitContainer();

            // Left panel controls
            this.panelSearch = new System.Windows.Forms.Panel();
            this.lblSearch = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnClearSearch = new System.Windows.Forms.Button();
            this.treeViewCategories = new System.Windows.Forms.TreeView();
            this.contextMenuTree = new System.Windows.Forms.ContextMenuStrip();
            this.menuItemCtxAddChild = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemCtxRename = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemCtxDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparatorCtx = new System.Windows.Forms.ToolStripSeparator();
            this.menuItemCtxAddHyperlink = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemCtxUploadFile = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemCtxAddRichText = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparatorCtx2 = new System.Windows.Forms.ToolStripSeparator();
            this.menuItemCtxAddRoot = new System.Windows.Forms.ToolStripMenuItem();
            this.panelTreeButtons = new System.Windows.Forms.Panel();
            this.btnAddRoot = new System.Windows.Forms.Button();
            this.btnAddChild = new System.Windows.Forms.Button();
            this.btnDeleteNode = new System.Windows.Forms.Button();
            this.btnExpandAll = new System.Windows.Forms.Button();
            this.btnCollapseAll = new System.Windows.Forms.Button();

            // Right panel controls
            this.panelNodeHeader = new System.Windows.Forms.Panel();
            this.lblNodeHeaderTitle = new System.Windows.Forms.Label();
            this.txtRenameNode = new System.Windows.Forms.TextBox();
            this.btnUpdateNodeName = new System.Windows.Forms.Button();
            this.lblBreadcrumb = new System.Windows.Forms.Label();

            this.tabControlContent = new System.Windows.Forms.TabControl();
            this.tabHyperlinks = new System.Windows.Forms.TabPage();
            this.tabFiles = new System.Windows.Forms.TabPage();
            this.tabDescriptions = new System.Windows.Forms.TabPage();

            // Search results overlay panel
            this.panelSearchResults = new System.Windows.Forms.Panel();
            this.lblSearchResultsHeader = new System.Windows.Forms.Label();
            this.btnCloseSearchResults = new System.Windows.Forms.Button();
            this.lvSearchResults = new System.Windows.Forms.ListView();
            this.colSearchNode = new System.Windows.Forms.ColumnHeader();
            this.colSearchCategory = new System.Windows.Forms.ColumnHeader();
            this.colSearchMatch = new System.Windows.Forms.ColumnHeader();
            this.colSearchPath = new System.Windows.Forms.ColumnHeader();

            // Hyperlinks Tab Controls
            this.lvHyperlinks = new System.Windows.Forms.ListView();
            this.colLinkTitle = new System.Windows.Forms.ColumnHeader();
            this.colLinkUrl = new System.Windows.Forms.ColumnHeader();
            this.panelLinkControls = new System.Windows.Forms.Panel();
            this.lblLinkTitle = new System.Windows.Forms.Label();
            this.txtLinkTitle = new System.Windows.Forms.TextBox();
            this.lblLinkUrl = new System.Windows.Forms.Label();
            this.txtLinkUrl = new System.Windows.Forms.TextBox();
            this.btnAddLink = new System.Windows.Forms.Button();
            this.btnEditLink = new System.Windows.Forms.Button();
            this.btnDeleteLink = new System.Windows.Forms.Button();
            this.btnOpenLink = new System.Windows.Forms.Button();

            // Files Tab Controls
            this.lvFiles = new System.Windows.Forms.ListView();
            this.colFileName = new System.Windows.Forms.ColumnHeader();
            this.colFileType = new System.Windows.Forms.ColumnHeader();
            this.colFileSize = new System.Windows.Forms.ColumnHeader();
            this.colFileDate = new System.Windows.Forms.ColumnHeader();
            this.panelFileControls = new System.Windows.Forms.Panel();
            this.btnUploadFile = new System.Windows.Forms.Button();
            this.btnOpenFile = new System.Windows.Forms.Button();
            this.btnDeleteFile = new System.Windows.Forms.Button();
            this.btnOpenNodeFolder = new System.Windows.Forms.Button();

            // Descriptions Tab Controls
            this.splitContainerDescriptions = new System.Windows.Forms.SplitContainer();
            this.lbDescriptions = new System.Windows.Forms.ListBox();
            this.panelDescListButtons = new System.Windows.Forms.Panel();
            this.btnAddDescription = new System.Windows.Forms.Button();
            this.btnDeleteDescription = new System.Windows.Forms.Button();
            this.panelDescEditor = new System.Windows.Forms.Panel();
            this.lblDescTitle = new System.Windows.Forms.Label();
            this.txtDescTitle = new System.Windows.Forms.TextBox();
            this.toolStripDescFormat = new System.Windows.Forms.ToolStrip();
            this.tsbBold = new System.Windows.Forms.ToolStripButton();
            this.tsbItalic = new System.Windows.Forms.ToolStripButton();
            this.tsbUnderline = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tscbFontFamily = new System.Windows.Forms.ToolStripComboBox();
            this.tscbFontSize = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbColor = new System.Windows.Forms.ToolStripButton();
            this.tsbBullet = new System.Windows.Forms.ToolStripButton();
            this.rtbDescriptionContent = new System.Windows.Forms.RichTextBox();
            this.panelDescBottom = new System.Windows.Forms.Panel();
            this.btnSaveDescription = new System.Windows.Forms.Button();
            this.lblDescStatus = new System.Windows.Forms.Label();

            this.menuStripMain.SuspendLayout();
            this.statusStripMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerMain)).BeginInit();
            this.splitContainerMain.Panel1.SuspendLayout();
            this.splitContainerMain.Panel2.SuspendLayout();
            this.splitContainerMain.SuspendLayout();
            this.panelSearch.SuspendLayout();
            this.panelTreeButtons.SuspendLayout();
            this.panelNodeHeader.SuspendLayout();
            this.tabControlContent.SuspendLayout();
            this.tabHyperlinks.SuspendLayout();
            this.tabFiles.SuspendLayout();
            this.tabDescriptions.SuspendLayout();
            this.panelSearchResults.SuspendLayout();
            this.panelLinkControls.SuspendLayout();
            this.panelFileControls.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerDescriptions)).BeginInit();
            this.splitContainerDescriptions.Panel1.SuspendLayout();
            this.splitContainerDescriptions.Panel2.SuspendLayout();
            this.splitContainerDescriptions.SuspendLayout();
            this.panelDescListButtons.SuspendLayout();
            this.panelDescEditor.SuspendLayout();
            this.toolStripDescFormat.SuspendLayout();
            this.panelDescBottom.SuspendLayout();
            this.SuspendLayout();

            //
            // menuStripMain
            //
            this.menuStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
                this.menuFile,
                this.menuTree,
                this.menuHelp
            });
            this.menuStripMain.Location = new System.Drawing.Point(0, 0);
            this.menuStripMain.Size = new System.Drawing.Size(1080, 26);
            this.menuStripMain.BackColor = System.Drawing.Color.FromArgb(245, 245, 245);

            // menuFile
            this.menuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
                this.menuOpenStorage,
                this.toolStripSeparator1,
                this.menuExit
            });
            this.menuFile.Text = "&File";

            this.menuOpenStorage.Text = "&Open Data Folder";
            this.menuOpenStorage.Click += new System.EventHandler(this.MenuOpenStorage_Click);

            this.menuExit.Text = "E&xit";
            this.menuExit.Click += new System.EventHandler(this.MenuExit_Click);

            // menuTree
            this.menuTree.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
                this.menuAddRoot,
                this.menuAddChild,
                this.menuRenameNode,
                this.menuDeleteNode,
                this.toolStripSeparator2,
                this.menuExpandAll,
                this.menuCollapseAll
            });
            this.menuTree.Text = "&Node Actions";

            this.menuAddRoot.Text = "Add &Root Node";
            this.menuAddRoot.Click += new System.EventHandler(this.BtnAddRoot_Click);

            this.menuAddChild.Text = "Add &Child Node";
            this.menuAddChild.Click += new System.EventHandler(this.BtnAddChild_Click);

            this.menuRenameNode.Text = "&Update Node Name";
            this.menuRenameNode.Click += new System.EventHandler(this.BtnUpdateNodeName_Click);

            this.menuDeleteNode.Text = "&Delete Selected Node";
            this.menuDeleteNode.Click += new System.EventHandler(this.BtnDeleteNode_Click);

            this.menuExpandAll.Text = "&Expand All";
            this.menuExpandAll.Click += new System.EventHandler(this.BtnExpandAll_Click);

            this.menuCollapseAll.Text = "&Collapse All";
            this.menuCollapseAll.Click += new System.EventHandler(this.BtnCollapseAll_Click);

            // menuHelp
            this.menuHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
                this.menuAbout
            });
            this.menuHelp.Text = "&Help";

            this.menuAbout.Text = "&About Tree-Based CMS";
            this.menuAbout.Click += new System.EventHandler(this.MenuAbout_Click);

            //
            // statusStripMain
            //
            this.statusStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
                this.statusLabel,
                this.statusNodeCount
            });
            this.statusStripMain.Location = new System.Drawing.Point(0, 678);
            this.statusStripMain.Size = new System.Drawing.Size(1080, 24);

            this.statusLabel.Spring = true;
            this.statusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.statusLabel.Text = "Ready";

            this.statusNodeCount.Text = "Nodes: 0";

            //
            // splitContainerMain
            // 
            this.splitContainerMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerMain.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainerMain.Location = new System.Drawing.Point(0, 26);
            this.splitContainerMain.SplitterDistance = 340;
            this.splitContainerMain.Size = new System.Drawing.Size(1080, 652);

            //
            // Panel 1 (Left - Tree and Search)
            //
            this.splitContainerMain.Panel1.Controls.Add(this.treeViewCategories);
            this.splitContainerMain.Panel1.Controls.Add(this.panelTreeButtons);
            this.splitContainerMain.Panel1.Controls.Add(this.panelSearch);
            this.splitContainerMain.Panel1.Padding = new System.Windows.Forms.Padding(6);

            // panelSearch
            this.panelSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSearch.Height = 70;
            this.panelSearch.Controls.Add(this.lblSearch);
            this.panelSearch.Controls.Add(this.txtSearch);
            this.panelSearch.Controls.Add(this.btnSearch);
            this.panelSearch.Controls.Add(this.btnClearSearch);

            this.lblSearch.Location = new System.Drawing.Point(2, 4);
            this.lblSearch.Size = new System.Drawing.Size(200, 16);
            this.lblSearch.Text = "Keyword Search:";
            this.lblSearch.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);

            this.txtSearch.Location = new System.Drawing.Point(4, 24);
            this.txtSearch.Size = new System.Drawing.Size(170, 25);
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtSearch_KeyDown);

            this.btnSearch.Location = new System.Drawing.Point(180, 23);
            this.btnSearch.Size = new System.Drawing.Size(65, 27);
            this.btnSearch.Text = "Search";
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(0, 120, 215);
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.Click += new System.EventHandler(this.BtnSearch_Click);

            this.btnClearSearch.Location = new System.Drawing.Point(249, 23);
            this.btnClearSearch.Size = new System.Drawing.Size(55, 27);
            this.btnClearSearch.Text = "Clear";
            this.btnClearSearch.BackColor = System.Drawing.Color.FromArgb(235, 235, 235);
            this.btnClearSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearSearch.FlatAppearance.BorderSize = 0;
            this.btnClearSearch.Click += new System.EventHandler(this.BtnClearSearch_Click);

            // treeViewCategories
            this.treeViewCategories.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeViewCategories.HideSelection = false;
            this.treeViewCategories.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.treeViewCategories.ShowLines = true;
            this.treeViewCategories.ShowPlusMinus = true;
            this.treeViewCategories.ShowRootLines = true;
            this.treeViewCategories.ContextMenuStrip = this.contextMenuTree;
            this.treeViewCategories.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.TreeViewCategories_AfterSelect);
            this.treeViewCategories.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.TreeViewCategories_NodeMouseClick);
            this.treeViewCategories.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.TreeViewCategories_NodeMouseDoubleClick);

            //
            // contextMenuTree
            //
            this.contextMenuTree.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
                this.menuItemCtxAddChild,
                this.menuItemCtxRename,
                this.menuItemCtxDelete,
                this.toolStripSeparatorCtx,
                this.menuItemCtxAddHyperlink,
                this.menuItemCtxUploadFile,
                this.menuItemCtxAddRichText,
                this.toolStripSeparatorCtx2,
                this.menuItemCtxAddRoot
            });
            this.contextMenuTree.Opening += new System.ComponentModel.CancelEventHandler(this.ContextMenuTree_Opening);

            // menuItemCtxAddChild
            this.menuItemCtxAddChild.Text = "Add Child Node";
            this.menuItemCtxAddChild.Click += new System.EventHandler(this.MenuItemCtxAddChild_Click);

            // menuItemCtxRename
            this.menuItemCtxRename.Text = "Rename Node";
            this.menuItemCtxRename.Click += new System.EventHandler(this.MenuItemCtxRename_Click);

            // menuItemCtxDelete
            this.menuItemCtxDelete.Text = "Delete Node";
            this.menuItemCtxDelete.Click += new System.EventHandler(this.MenuItemCtxDelete_Click);

            // menuItemCtxAddHyperlink
            this.menuItemCtxAddHyperlink.Text = "Add Hyperlink";
            this.menuItemCtxAddHyperlink.Click += new System.EventHandler(this.MenuItemCtxAddHyperlink_Click);

            // menuItemCtxUploadFile
            this.menuItemCtxUploadFile.Text = "Upload File";
            this.menuItemCtxUploadFile.Click += new System.EventHandler(this.MenuItemCtxUploadFile_Click);

            // menuItemCtxAddRichText
            this.menuItemCtxAddRichText.Text = "Add Rich Text";
            this.menuItemCtxAddRichText.Click += new System.EventHandler(this.MenuItemCtxAddRichText_Click);

            // menuItemCtxAddRoot
            this.menuItemCtxAddRoot.Text = "Add Root Node";
            this.menuItemCtxAddRoot.Click += new System.EventHandler(this.MenuItemCtxAddRoot_Click);

            // panelTreeButtons
            this.panelTreeButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelTreeButtons.Height = 72;
            this.panelTreeButtons.Controls.Add(this.btnAddRoot);
            this.panelTreeButtons.Controls.Add(this.btnAddChild);
            this.panelTreeButtons.Controls.Add(this.btnDeleteNode);
            this.panelTreeButtons.Controls.Add(this.btnExpandAll);
            this.panelTreeButtons.Controls.Add(this.btnCollapseAll);

            this.btnAddRoot.Location = new System.Drawing.Point(2, 6);
            this.btnAddRoot.Size = new System.Drawing.Size(96, 28);
            this.btnAddRoot.Text = "+ Add Root";
            this.btnAddRoot.BackColor = System.Drawing.Color.FromArgb(46, 125, 50);
            this.btnAddRoot.ForeColor = System.Drawing.Color.White;
            this.btnAddRoot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddRoot.FlatAppearance.BorderSize = 0;
            this.btnAddRoot.Click += new System.EventHandler(this.BtnAddRoot_Click);

            this.btnAddChild.Location = new System.Drawing.Point(103, 6);
            this.btnAddChild.Size = new System.Drawing.Size(96, 28);
            this.btnAddChild.Text = "+ Add Child";
            this.btnAddChild.BackColor = System.Drawing.Color.FromArgb(2, 119, 189);
            this.btnAddChild.ForeColor = System.Drawing.Color.White;
            this.btnAddChild.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddChild.FlatAppearance.BorderSize = 0;
            this.btnAddChild.Click += new System.EventHandler(this.BtnAddChild_Click);

            this.btnDeleteNode.Location = new System.Drawing.Point(204, 6);
            this.btnDeleteNode.Size = new System.Drawing.Size(96, 28);
            this.btnDeleteNode.Text = "Delete Node";
            this.btnDeleteNode.BackColor = System.Drawing.Color.FromArgb(198, 40, 40);
            this.btnDeleteNode.ForeColor = System.Drawing.Color.White;
            this.btnDeleteNode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteNode.FlatAppearance.BorderSize = 0;
            this.btnDeleteNode.Click += new System.EventHandler(this.BtnDeleteNode_Click);

            this.btnExpandAll.Location = new System.Drawing.Point(2, 38);
            this.btnExpandAll.Size = new System.Drawing.Size(147, 26);
            this.btnExpandAll.Text = "Expand All";
            this.btnExpandAll.BackColor = System.Drawing.Color.FromArgb(240, 240, 240);
            this.btnExpandAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExpandAll.FlatAppearance.BorderSize = 0;
            this.btnExpandAll.Click += new System.EventHandler(this.BtnExpandAll_Click);

            this.btnCollapseAll.Location = new System.Drawing.Point(153, 38);
            this.btnCollapseAll.Size = new System.Drawing.Size(147, 26);
            this.btnCollapseAll.Text = "Collapse All";
            this.btnCollapseAll.BackColor = System.Drawing.Color.FromArgb(240, 240, 240);
            this.btnCollapseAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCollapseAll.FlatAppearance.BorderSize = 0;
            this.btnCollapseAll.Click += new System.EventHandler(this.BtnCollapseAll_Click);

            //
            // Panel 2 (Right - Node Details & Content Tabs)
            //
            this.splitContainerMain.Panel2.Controls.Add(this.tabControlContent);
            this.splitContainerMain.Panel2.Controls.Add(this.panelSearchResults);
            this.splitContainerMain.Panel2.Controls.Add(this.panelNodeHeader);
            this.splitContainerMain.Panel2.Padding = new System.Windows.Forms.Padding(6);

            // panelNodeHeader
            this.panelNodeHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelNodeHeader.Height = 72;
            this.panelNodeHeader.BackColor = System.Drawing.Color.FromArgb(248, 249, 250);
            this.panelNodeHeader.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelNodeHeader.Controls.Add(this.lblNodeHeaderTitle);
            this.panelNodeHeader.Controls.Add(this.txtRenameNode);
            this.panelNodeHeader.Controls.Add(this.btnUpdateNodeName);
            this.panelNodeHeader.Controls.Add(this.lblBreadcrumb);

            this.lblNodeHeaderTitle.Location = new System.Drawing.Point(12, 10);
            this.lblNodeHeaderTitle.Size = new System.Drawing.Size(95, 23);
            this.lblNodeHeaderTitle.Text = "Node Name:";
            this.lblNodeHeaderTitle.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);

            this.txtRenameNode.Location = new System.Drawing.Point(110, 8);
            this.txtRenameNode.Size = new System.Drawing.Size(320, 26);
            this.txtRenameNode.Font = new System.Drawing.Font("Segoe UI", 10F);

            this.btnUpdateNodeName.Location = new System.Drawing.Point(438, 7);
            this.btnUpdateNodeName.Size = new System.Drawing.Size(110, 28);
            this.btnUpdateNodeName.Text = "Update Node";
            this.btnUpdateNodeName.BackColor = System.Drawing.Color.FromArgb(0, 120, 215);
            this.btnUpdateNodeName.ForeColor = System.Drawing.Color.White;
            this.btnUpdateNodeName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateNodeName.FlatAppearance.BorderSize = 0;
            this.btnUpdateNodeName.Click += new System.EventHandler(this.BtnUpdateNodeName_Click);

            this.lblBreadcrumb.Location = new System.Drawing.Point(12, 42);
            this.lblBreadcrumb.Size = new System.Drawing.Size(650, 20);
            this.lblBreadcrumb.Text = "Path: (Select a node from the tree)";
            this.lblBreadcrumb.ForeColor = System.Drawing.Color.FromArgb(100, 100, 100);

            // panelSearchResults
            this.panelSearchResults.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSearchResults.Height = 175;
            this.panelSearchResults.BackColor = System.Drawing.Color.FromArgb(254, 250, 235);
            this.panelSearchResults.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelSearchResults.Visible = false;
            this.panelSearchResults.Controls.Add(this.lvSearchResults);
            this.panelSearchResults.Controls.Add(this.btnCloseSearchResults);
            this.panelSearchResults.Controls.Add(this.lblSearchResultsHeader);

            this.lblSearchResultsHeader.Location = new System.Drawing.Point(10, 8);
            this.lblSearchResultsHeader.Size = new System.Drawing.Size(400, 20);
            this.lblSearchResultsHeader.Text = "Search Results (Double-click to navigate):";
            this.lblSearchResultsHeader.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblSearchResultsHeader.ForeColor = System.Drawing.Color.FromArgb(130, 80, 0);

            this.btnCloseSearchResults.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCloseSearchResults.Location = new System.Drawing.Point(620, 5);
            this.btnCloseSearchResults.Size = new System.Drawing.Size(100, 24);
            this.btnCloseSearchResults.Text = "Close Results";
            this.btnCloseSearchResults.BackColor = System.Drawing.Color.FromArgb(240, 240, 240);
            this.btnCloseSearchResults.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCloseSearchResults.FlatAppearance.BorderSize = 0;
            this.btnCloseSearchResults.Click += new System.EventHandler(this.BtnCloseSearchResults_Click);

            this.lvSearchResults.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvSearchResults.Location = new System.Drawing.Point(10, 32);
            this.lvSearchResults.Size = new System.Drawing.Size(710, 133);
            this.lvSearchResults.View = System.Windows.Forms.View.Details;
            this.lvSearchResults.FullRowSelect = true;
            this.lvSearchResults.GridLines = true;
            this.lvSearchResults.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
                this.colSearchNode,
                this.colSearchCategory,
                this.colSearchMatch,
                this.colSearchPath
            });
            this.lvSearchResults.DoubleClick += new System.EventHandler(this.LvSearchResults_DoubleClick);

            this.colSearchNode.Text = "Node";
            this.colSearchNode.Width = 140;

            this.colSearchCategory.Text = "Category";
            this.colSearchCategory.Width = 110;

            this.colSearchMatch.Text = "Matched Content";
            this.colSearchMatch.Width = 240;

            this.colSearchPath.Text = "Hierarchy Path";
            this.colSearchPath.Width = 200;

            // tabControlContent
            this.tabControlContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlContent.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.tabControlContent.Controls.Add(this.tabHyperlinks);
            this.tabControlContent.Controls.Add(this.tabFiles);
            this.tabControlContent.Controls.Add(this.tabDescriptions);

            // ==================== TAB 1: HYPERLINKS ====================
            this.tabHyperlinks.Text = "  Hyperlinks  ";
            this.tabHyperlinks.Controls.Add(this.lvHyperlinks);
            this.tabHyperlinks.Controls.Add(this.panelLinkControls);

            this.lvHyperlinks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvHyperlinks.View = System.Windows.Forms.View.Details;
            this.lvHyperlinks.FullRowSelect = true;
            this.lvHyperlinks.GridLines = true;
            this.lvHyperlinks.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
                this.colLinkTitle,
                this.colLinkUrl
            });
            this.lvHyperlinks.SelectedIndexChanged += new System.EventHandler(this.LvHyperlinks_SelectedIndexChanged);
            this.lvHyperlinks.DoubleClick += new System.EventHandler(this.LvHyperlinks_DoubleClick);

            this.colLinkTitle.Text = "Link Title";
            this.colLinkTitle.Width = 230;

            this.colLinkUrl.Text = "Web URL";
            this.colLinkUrl.Width = 460;

            this.panelLinkControls.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelLinkControls.Height = 110;
            this.panelLinkControls.BackColor = System.Drawing.Color.FromArgb(249, 249, 250);
            this.panelLinkControls.Controls.Add(this.lblLinkTitle);
            this.panelLinkControls.Controls.Add(this.txtLinkTitle);
            this.panelLinkControls.Controls.Add(this.lblLinkUrl);
            this.panelLinkControls.Controls.Add(this.txtLinkUrl);
            this.panelLinkControls.Controls.Add(this.btnAddLink);
            this.panelLinkControls.Controls.Add(this.btnEditLink);
            this.panelLinkControls.Controls.Add(this.btnDeleteLink);
            this.panelLinkControls.Controls.Add(this.btnOpenLink);

            this.lblLinkTitle.Location = new System.Drawing.Point(12, 10);
            this.lblLinkTitle.Size = new System.Drawing.Size(75, 20);
            this.lblLinkTitle.Text = "Title:";

            this.txtLinkTitle.Location = new System.Drawing.Point(85, 8);
            this.txtLinkTitle.Size = new System.Drawing.Size(250, 25);

            this.lblLinkUrl.Location = new System.Drawing.Point(345, 10);
            this.lblLinkUrl.Size = new System.Drawing.Size(40, 20);
            this.lblLinkUrl.Text = "URL:";

            this.txtLinkUrl.Location = new System.Drawing.Point(390, 8);
            this.txtLinkUrl.Size = new System.Drawing.Size(320, 25);

            this.btnAddLink.Location = new System.Drawing.Point(85, 45);
            this.btnAddLink.Size = new System.Drawing.Size(120, 32);
            this.btnAddLink.Text = "Add Hyperlink";
            this.btnAddLink.BackColor = System.Drawing.Color.FromArgb(46, 125, 50);
            this.btnAddLink.ForeColor = System.Drawing.Color.White;
            this.btnAddLink.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddLink.FlatAppearance.BorderSize = 0;
            this.btnAddLink.Click += new System.EventHandler(this.BtnAddLink_Click);

            this.btnEditLink.Location = new System.Drawing.Point(215, 45);
            this.btnEditLink.Size = new System.Drawing.Size(120, 32);
            this.btnEditLink.Text = "Edit Hyperlink";
            this.btnEditLink.BackColor = System.Drawing.Color.FromArgb(0, 120, 215);
            this.btnEditLink.ForeColor = System.Drawing.Color.White;
            this.btnEditLink.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditLink.FlatAppearance.BorderSize = 0;
            this.btnEditLink.Click += new System.EventHandler(this.BtnEditLink_Click);

            this.btnDeleteLink.Location = new System.Drawing.Point(345, 45);
            this.btnDeleteLink.Size = new System.Drawing.Size(125, 32);
            this.btnDeleteLink.Text = "Delete Hyperlink";
            this.btnDeleteLink.BackColor = System.Drawing.Color.FromArgb(198, 40, 40);
            this.btnDeleteLink.ForeColor = System.Drawing.Color.White;
            this.btnDeleteLink.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteLink.FlatAppearance.BorderSize = 0;
            this.btnDeleteLink.Click += new System.EventHandler(this.BtnDeleteLink_Click);

            this.btnOpenLink.Location = new System.Drawing.Point(480, 45);
            this.btnOpenLink.Size = new System.Drawing.Size(170, 32);
            this.btnOpenLink.Text = "Open in Browser";
            this.btnOpenLink.BackColor = System.Drawing.Color.FromArgb(106, 27, 154);
            this.btnOpenLink.ForeColor = System.Drawing.Color.White;
            this.btnOpenLink.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpenLink.FlatAppearance.BorderSize = 0;
            this.btnOpenLink.Click += new System.EventHandler(this.BtnOpenLink_Click);

            // ==================== TAB 2: FILES ====================
            this.tabFiles.Text = "  Uploaded Files  ";
            this.tabFiles.Controls.Add(this.lvFiles);
            this.tabFiles.Controls.Add(this.panelFileControls);

            this.lvFiles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvFiles.View = System.Windows.Forms.View.Details;
            this.lvFiles.FullRowSelect = true;
            this.lvFiles.GridLines = true;
            this.lvFiles.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
                this.colFileName,
                this.colFileType,
                this.colFileSize,
                this.colFileDate
            });
            this.lvFiles.DoubleClick += new System.EventHandler(this.LvFiles_DoubleClick);

            this.colFileName.Text = "File Name";
            this.colFileName.Width = 300;

            this.colFileType.Text = "Extension";
            this.colFileType.Width = 90;

            this.colFileSize.Text = "Size (Bytes)";
            this.colFileSize.Width = 120;

            this.colFileDate.Text = "Date Modified";
            this.colFileDate.Width = 170;

            this.panelFileControls.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelFileControls.Height = 65;
            this.panelFileControls.BackColor = System.Drawing.Color.FromArgb(249, 249, 250);
            this.panelFileControls.Controls.Add(this.btnUploadFile);
            this.panelFileControls.Controls.Add(this.btnOpenFile);
            this.panelFileControls.Controls.Add(this.btnDeleteFile);
            this.panelFileControls.Controls.Add(this.btnOpenNodeFolder);

            this.btnUploadFile.Location = new System.Drawing.Point(12, 16);
            this.btnUploadFile.Size = new System.Drawing.Size(140, 34);
            this.btnUploadFile.Text = "Upload Files...";
            this.btnUploadFile.BackColor = System.Drawing.Color.FromArgb(46, 125, 50);
            this.btnUploadFile.ForeColor = System.Drawing.Color.White;
            this.btnUploadFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUploadFile.FlatAppearance.BorderSize = 0;
            this.btnUploadFile.Click += new System.EventHandler(this.BtnUploadFile_Click);

            this.btnOpenFile.Location = new System.Drawing.Point(162, 16);
            this.btnOpenFile.Size = new System.Drawing.Size(140, 34);
            this.btnOpenFile.Text = "Open Selected File";
            this.btnOpenFile.BackColor = System.Drawing.Color.FromArgb(0, 120, 215);
            this.btnOpenFile.ForeColor = System.Drawing.Color.White;
            this.btnOpenFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpenFile.FlatAppearance.BorderSize = 0;
            this.btnOpenFile.Click += new System.EventHandler(this.BtnOpenFile_Click);

            this.btnDeleteFile.Location = new System.Drawing.Point(312, 16);
            this.btnDeleteFile.Size = new System.Drawing.Size(140, 34);
            this.btnDeleteFile.Text = "Delete File";
            this.btnDeleteFile.BackColor = System.Drawing.Color.FromArgb(198, 40, 40);
            this.btnDeleteFile.ForeColor = System.Drawing.Color.White;
            this.btnDeleteFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteFile.FlatAppearance.BorderSize = 0;
            this.btnDeleteFile.Click += new System.EventHandler(this.BtnDeleteFile_Click);

            this.btnOpenNodeFolder.Location = new System.Drawing.Point(462, 16);
            this.btnOpenNodeFolder.Size = new System.Drawing.Size(160, 34);
            this.btnOpenNodeFolder.Text = "Open Storage Folder";
            this.btnOpenNodeFolder.BackColor = System.Drawing.Color.FromArgb(106, 27, 154);
            this.btnOpenNodeFolder.ForeColor = System.Drawing.Color.White;
            this.btnOpenNodeFolder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpenNodeFolder.FlatAppearance.BorderSize = 0;
            this.btnOpenNodeFolder.Click += new System.EventHandler(this.BtnOpenNodeFolder_Click);

            // ==================== TAB 3: DESCRIPTIONS ====================
            this.tabDescriptions.Text = "  Rich-Text Descriptions  ";
            this.tabDescriptions.Controls.Add(this.splitContainerDescriptions);

            this.splitContainerDescriptions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerDescriptions.SplitterDistance = 210;

            // Descriptions List Subpanel
            this.splitContainerDescriptions.Panel1.Controls.Add(this.lbDescriptions);
            this.splitContainerDescriptions.Panel1.Controls.Add(this.panelDescListButtons);
            this.splitContainerDescriptions.Panel1.Padding = new System.Windows.Forms.Padding(4);

            this.lbDescriptions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbDescriptions.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lbDescriptions.IntegralHeight = false;
            this.lbDescriptions.SelectedIndexChanged += new System.EventHandler(this.LbDescriptions_SelectedIndexChanged);

            this.panelDescListButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelDescListButtons.Height = 44;
            this.panelDescListButtons.Controls.Add(this.btnAddDescription);
            this.panelDescListButtons.Controls.Add(this.btnDeleteDescription);

            this.btnAddDescription.Location = new System.Drawing.Point(4, 6);
            this.btnAddDescription.Size = new System.Drawing.Size(95, 30);
            this.btnAddDescription.Text = "+ Add New";
            this.btnAddDescription.BackColor = System.Drawing.Color.FromArgb(46, 125, 50);
            this.btnAddDescription.ForeColor = System.Drawing.Color.White;
            this.btnAddDescription.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddDescription.FlatAppearance.BorderSize = 0;
            this.btnAddDescription.Click += new System.EventHandler(this.BtnAddDescription_Click);

            this.btnDeleteDescription.Location = new System.Drawing.Point(105, 6);
            this.btnDeleteDescription.Size = new System.Drawing.Size(95, 30);
            this.btnDeleteDescription.Text = "Delete";
            this.btnDeleteDescription.BackColor = System.Drawing.Color.FromArgb(198, 40, 40);
            this.btnDeleteDescription.ForeColor = System.Drawing.Color.White;
            this.btnDeleteDescription.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteDescription.FlatAppearance.BorderSize = 0;
            this.btnDeleteDescription.Click += new System.EventHandler(this.BtnDeleteDescription_Click);

            // Descriptions Editor Subpanel
            this.splitContainerDescriptions.Panel2.Controls.Add(this.rtbDescriptionContent);
            this.splitContainerDescriptions.Panel2.Controls.Add(this.panelDescBottom);
            this.splitContainerDescriptions.Panel2.Controls.Add(this.toolStripDescFormat);
            this.splitContainerDescriptions.Panel2.Controls.Add(this.panelDescEditor);
            this.splitContainerDescriptions.Panel2.Padding = new System.Windows.Forms.Padding(4);

            this.panelDescEditor.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelDescEditor.Height = 40;
            this.panelDescEditor.Controls.Add(this.lblDescTitle);
            this.panelDescEditor.Controls.Add(this.txtDescTitle);

            this.lblDescTitle.Location = new System.Drawing.Point(4, 10);
            this.lblDescTitle.Size = new System.Drawing.Size(110, 20);
            this.lblDescTitle.Text = "Description Title:";
            this.lblDescTitle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);

            this.txtDescTitle.Location = new System.Drawing.Point(120, 8);
            this.txtDescTitle.Size = new System.Drawing.Size(380, 25);

            // Formatting ToolStrip
            this.toolStripDescFormat.Dock = System.Windows.Forms.DockStyle.Top;
            this.toolStripDescFormat.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
                this.tsbBold,
                this.tsbItalic,
                this.tsbUnderline,
                this.toolStripSeparator3,
                this.tscbFontFamily,
                this.tscbFontSize,
                this.toolStripSeparator4,
                this.tsbColor,
                this.tsbBullet
            });

            this.tsbBold.Text = "B";
            this.tsbBold.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.tsbBold.ToolTipText = "Bold";
            this.tsbBold.Click += new System.EventHandler(this.TsbBold_Click);

            this.tsbItalic.Text = "I";
            this.tsbItalic.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Italic);
            this.tsbItalic.ToolTipText = "Italic";
            this.tsbItalic.Click += new System.EventHandler(this.TsbItalic_Click);

            this.tsbUnderline.Text = "U";
            this.tsbUnderline.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Underline);
            this.tsbUnderline.ToolTipText = "Underline";
            this.tsbUnderline.Click += new System.EventHandler(this.TsbUnderline_Click);

            this.tscbFontFamily.Items.AddRange(new object[] {
                "Segoe UI", "Arial", "Calibri", "Times New Roman", "Consolas", "Courier New", "Tahoma", "Verdana"
            });
            this.tscbFontFamily.SelectedIndex = 0;
            this.tscbFontFamily.SelectedIndexChanged += new System.EventHandler(this.TscbFontFamily_SelectedIndexChanged);

            this.tscbFontSize.Items.AddRange(new object[] {
                "9", "10", "11", "12", "14", "16", "18", "20", "24", "28"
            });
            this.tscbFontSize.SelectedIndex = 2; // 11
            this.tscbFontSize.SelectedIndexChanged += new System.EventHandler(this.TscbFontSize_SelectedIndexChanged);

            this.tsbColor.Text = "Color";
            this.tsbColor.ToolTipText = "Text Color";
            this.tsbColor.Click += new System.EventHandler(this.TsbColor_Click);

            this.tsbBullet.Text = "Bullets";
            this.tsbBullet.ToolTipText = "Toggle Bullet Points";
            this.tsbBullet.Click += new System.EventHandler(this.TsbBullet_Click);

            // RichTextBox editor
            this.rtbDescriptionContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbDescriptionContent.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.rtbDescriptionContent.BackColor = System.Drawing.Color.White;

            // Panel bottom (Save button)
            this.panelDescBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelDescBottom.Height = 44;
            this.panelDescBottom.Controls.Add(this.btnSaveDescription);
            this.panelDescBottom.Controls.Add(this.lblDescStatus);

            this.btnSaveDescription.Location = new System.Drawing.Point(4, 6);
            this.btnSaveDescription.Size = new System.Drawing.Size(150, 32);
            this.btnSaveDescription.Text = "Save Description";
            this.btnSaveDescription.BackColor = System.Drawing.Color.FromArgb(0, 120, 215);
            this.btnSaveDescription.ForeColor = System.Drawing.Color.White;
            this.btnSaveDescription.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveDescription.FlatAppearance.BorderSize = 0;
            this.btnSaveDescription.Click += new System.EventHandler(this.BtnSaveDescription_Click);

            this.lblDescStatus.Location = new System.Drawing.Point(170, 12);
            this.lblDescStatus.Size = new System.Drawing.Size(350, 20);
            this.lblDescStatus.Text = "";
            this.lblDescStatus.ForeColor = System.Drawing.Color.FromArgb(46, 125, 50);

            //
            // MainForm Setup
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1080, 702);
            this.Controls.Add(this.splitContainerMain);
            this.Controls.Add(this.statusStripMain);
            this.Controls.Add(this.menuStripMain);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.MainMenuStrip = this.menuStripMain;
            this.MinimumSize = new System.Drawing.Size(850, 600);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tree-Based Content Management System | Coding Skills 2";
            this.Load += new System.EventHandler(this.MainForm_Load);

            this.menuStripMain.ResumeLayout(false);
            this.menuStripMain.PerformLayout();
            this.statusStripMain.ResumeLayout(false);
            this.statusStripMain.PerformLayout();
            this.splitContainerMain.Panel1.ResumeLayout(false);
            this.splitContainerMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerMain)).EndInit();
            this.splitContainerMain.ResumeLayout(false);
            this.panelSearch.ResumeLayout(false);
            this.panelSearch.PerformLayout();
            this.panelTreeButtons.ResumeLayout(false);
            this.panelNodeHeader.ResumeLayout(false);
            this.panelNodeHeader.PerformLayout();
            this.tabControlContent.ResumeLayout(false);
            this.tabHyperlinks.ResumeLayout(false);
            this.tabFiles.ResumeLayout(false);
            this.tabDescriptions.ResumeLayout(false);
            this.panelSearchResults.ResumeLayout(false);
            this.panelLinkControls.ResumeLayout(false);
            this.panelLinkControls.PerformLayout();
            this.panelFileControls.ResumeLayout(false);
            this.splitContainerDescriptions.Panel1.ResumeLayout(false);
            this.splitContainerDescriptions.Panel2.ResumeLayout(false);
            this.splitContainerDescriptions.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerDescriptions)).EndInit();
            this.splitContainerDescriptions.ResumeLayout(false);
            this.panelDescListButtons.ResumeLayout(false);
            this.panelDescEditor.ResumeLayout(false);
            this.panelDescEditor.PerformLayout();
            this.toolStripDescFormat.ResumeLayout(false);
            this.toolStripDescFormat.PerformLayout();
            this.panelDescBottom.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.MenuStrip menuStripMain;
        private System.Windows.Forms.ToolStripMenuItem menuFile;
        private System.Windows.Forms.ToolStripMenuItem menuOpenStorage;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem menuExit;
        private System.Windows.Forms.ToolStripMenuItem menuTree;
        private System.Windows.Forms.ToolStripMenuItem menuAddRoot;
        private System.Windows.Forms.ToolStripMenuItem menuAddChild;
        private System.Windows.Forms.ToolStripMenuItem menuRenameNode;
        private System.Windows.Forms.ToolStripMenuItem menuDeleteNode;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem menuExpandAll;
        private System.Windows.Forms.ToolStripMenuItem menuCollapseAll;
        private System.Windows.Forms.ToolStripMenuItem menuHelp;
        private System.Windows.Forms.ToolStripMenuItem menuAbout;

        private System.Windows.Forms.StatusStrip statusStripMain;
        private System.Windows.Forms.ToolStripStatusLabel statusLabel;
        private System.Windows.Forms.ToolStripStatusLabel statusNodeCount;

        private System.Windows.Forms.SplitContainer splitContainerMain;

        private System.Windows.Forms.Panel panelSearch;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnClearSearch;
        private System.Windows.Forms.TreeView treeViewCategories;
        private System.Windows.Forms.ContextMenuStrip contextMenuTree;
        private System.Windows.Forms.ToolStripMenuItem menuItemCtxAddChild;
        private System.Windows.Forms.ToolStripMenuItem menuItemCtxRename;
        private System.Windows.Forms.ToolStripMenuItem menuItemCtxDelete;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparatorCtx;
        private System.Windows.Forms.ToolStripMenuItem menuItemCtxAddHyperlink;
        private System.Windows.Forms.ToolStripMenuItem menuItemCtxUploadFile;
        private System.Windows.Forms.ToolStripMenuItem menuItemCtxAddRichText;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparatorCtx2;
        private System.Windows.Forms.ToolStripMenuItem menuItemCtxAddRoot;
        private System.Windows.Forms.Panel panelTreeButtons;
        private System.Windows.Forms.Button btnAddRoot;
        private System.Windows.Forms.Button btnAddChild;
        private System.Windows.Forms.Button btnDeleteNode;
        private System.Windows.Forms.Button btnExpandAll;
        private System.Windows.Forms.Button btnCollapseAll;

        private System.Windows.Forms.Panel panelNodeHeader;
        private System.Windows.Forms.Label lblNodeHeaderTitle;
        private System.Windows.Forms.TextBox txtRenameNode;
        private System.Windows.Forms.Button btnUpdateNodeName;
        private System.Windows.Forms.Label lblBreadcrumb;

        private System.Windows.Forms.TabControl tabControlContent;
        private System.Windows.Forms.TabPage tabHyperlinks;
        private System.Windows.Forms.TabPage tabFiles;
        private System.Windows.Forms.TabPage tabDescriptions;

        private System.Windows.Forms.Panel panelSearchResults;
        private System.Windows.Forms.Label lblSearchResultsHeader;
        private System.Windows.Forms.Button btnCloseSearchResults;
        private System.Windows.Forms.ListView lvSearchResults;
        private System.Windows.Forms.ColumnHeader colSearchNode;
        private System.Windows.Forms.ColumnHeader colSearchCategory;
        private System.Windows.Forms.ColumnHeader colSearchMatch;
        private System.Windows.Forms.ColumnHeader colSearchPath;

        private System.Windows.Forms.ListView lvHyperlinks;
        private System.Windows.Forms.ColumnHeader colLinkTitle;
        private System.Windows.Forms.ColumnHeader colLinkUrl;
        private System.Windows.Forms.Panel panelLinkControls;
        private System.Windows.Forms.Label lblLinkTitle;
        private System.Windows.Forms.TextBox txtLinkTitle;
        private System.Windows.Forms.Label lblLinkUrl;
        private System.Windows.Forms.TextBox txtLinkUrl;
        private System.Windows.Forms.Button btnAddLink;
        private System.Windows.Forms.Button btnEditLink;
        private System.Windows.Forms.Button btnDeleteLink;
        private System.Windows.Forms.Button btnOpenLink;

        private System.Windows.Forms.ListView lvFiles;
        private System.Windows.Forms.ColumnHeader colFileName;
        private System.Windows.Forms.ColumnHeader colFileType;
        private System.Windows.Forms.ColumnHeader colFileSize;
        private System.Windows.Forms.ColumnHeader colFileDate;
        private System.Windows.Forms.Panel panelFileControls;
        private System.Windows.Forms.Button btnUploadFile;
        private System.Windows.Forms.Button btnOpenFile;
        private System.Windows.Forms.Button btnDeleteFile;
        private System.Windows.Forms.Button btnOpenNodeFolder;

        private System.Windows.Forms.SplitContainer splitContainerDescriptions;
        private System.Windows.Forms.ListBox lbDescriptions;
        private System.Windows.Forms.Panel panelDescListButtons;
        private System.Windows.Forms.Button btnAddDescription;
        private System.Windows.Forms.Button btnDeleteDescription;
        private System.Windows.Forms.Panel panelDescEditor;
        private System.Windows.Forms.Label lblDescTitle;
        private System.Windows.Forms.TextBox txtDescTitle;
        private System.Windows.Forms.ToolStrip toolStripDescFormat;
        private System.Windows.Forms.ToolStripButton tsbBold;
        private System.Windows.Forms.ToolStripButton tsbItalic;
        private System.Windows.Forms.ToolStripButton tsbUnderline;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripComboBox tscbFontFamily;
        private System.Windows.Forms.ToolStripComboBox tscbFontSize;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton tsbColor;
        private System.Windows.Forms.ToolStripButton tsbBullet;
        private System.Windows.Forms.RichTextBox rtbDescriptionContent;
        private System.Windows.Forms.Panel panelDescBottom;
        private System.Windows.Forms.Button btnSaveDescription;
        private System.Windows.Forms.Label lblDescStatus;
    }
}

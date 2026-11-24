# Tree-Based Content Management System (TreeCMS) - Version 2
## Coding Skills 2 – Desktop Application Project (V2)

A desktop content management system developed in **C#** and **Windows Forms (WinForms)** for **Visual Studio 2026 / 2022**. The application organizes content into categories and subcategories using a hierarchical tree structure, backed entirely by a **simple text-file and local directory storage system** without databases, complex architectures, or external APIs.

### 🌟 Faculty Requested Features Implemented in Version 2:
1. **Complete 6-Option Right-Click Context Menu on Categories:**
   - **Add Child Node**: Directly adds a subcategory under the selected category.
   - **Rename Node**: Prompts to rename the selected category in-place.
   - **Delete Node**: Prompts for confirmation and deletes the category, subcategories, and files.
   - **Add Hyperlink**: Opens hyperlink dialog, adds the link, and immediately updates TreeView.
   - **Upload File**: Opens file picker (`OpenFileDialog`), copies files into local storage, and updates TreeView.
   - **Add Rich Text**: Prompts for description title, creates a new RTF note, and updates TreeView.
   - **Add Root Node**: Displays when right-clicking on empty TreeView area to create top-level categories.
   - *Right-clicking any category node automatically selects it before displaying the menu.*

2. **Expandable Content Groups under Each Category:**
   - Each category displays its stored content directly in the TreeView:
     ```
     Programming
       Java
         Hyperlinks
           Language Reference
         Uploaded Files
           sample_notes.txt
         Rich Text
           Module Notes
       Python
         Hyperlinks
         Uploaded Files
         Rich Text
     ```
   - **Double-Clicking Items:**
     - **Hyperlink**: Opens saved URL in default web browser.
     - **Uploaded File**: Opens file using default registered Windows viewer.
     - **Rich Text**: Loads description into the rich-text editor for viewing/editing.
   - **Immediate Refresh**: TreeView content automatically updates whenever a hyperlink, file, or description is added, edited, or deleted.
   - **State Persistence**: Hierarchy and content reload automatically when application is restarted.



---

## Table of Contents
1. [Application Overview](#application-overview)
2. [Technology Stack](#technology-stack)
3. [Architecture and File Storage Design](#architecture-and-file-storage-design)
4. [Project Structure](#project-structure)
5. [How to Open, Build, and Run](#how-to-open-build-and-run)
6. [Key Features and Implementation Details](#key-features-and-implementation-details)
7. [Error Handling and Validation](#error-handling-and-validation)
8. [Faculty Viva Preparation (Questions & Answers)](#faculty-viva-preparation-questions--answers)

---

## 1. Application Overview

TreeCMS allows users to organize content into categories and subcategories. Each node in the tree hierarchy contains:
- **Node Name**: Title of the category or subcategory with in-place renaming.
- **Multiple Hyperlinks**: Web links with title and URL, openable in the system default browser.
- **Multiple Uploaded Files**: Any file type (PDF, Word documents, images, text files) copied directly to the node's local folder and openable with system associations.
- **Multiple Rich-Text Descriptions**: Formatted notes with Bold, Italic, Underline, font family, font size, text color, and bullet points saved as RTF files.
- **Universal Keyword Search**: Case-insensitive search across node names, hyperlinks, description text, and uploaded filenames with one-click navigation to the matched node and tab.

---

## 2. Technology Stack

- **Operating System:** Windows (10/11)
- **IDE:** Visual Studio 2026 / Visual Studio 2022
- **Language:** C#
- **Application Type:** Windows Forms (.NET Framework 4.8 / Windows Desktop)
- **Backend:** Pure Text Files (`.txt`) and Rich Text Format (`.rtf`) via `System.IO`
- **Dependencies:** Standard .NET Framework class libraries (`System.Windows.Forms`, `System.Drawing`, `System.IO`, `System.Diagnostics`). No external NuGet packages required.

---

## 3. Architecture and File Storage Design

All data is stored inside a `Data/` folder located right next to the executable:

```
Data/
│
├── tree.txt                        <-- Master hierarchy index
│
└── Nodes/
    ├── Programming/
    │   ├── node.txt                <-- Node metadata (Id, Name, ParentId, CreatedDate)
    │   ├── hyperlinks.txt          <-- Saved links (Title|URL)
    │   ├── descriptions.txt        <-- Descriptions index (FileName|Title)
    │   ├── desc_1.rtf              <-- Rich-text description content
    │   └── Files/                  <-- Uploaded files
    │       └── HelloWorld.java
    │
    ├── Java/
    │   ├── node.txt
    │   ├── hyperlinks.txt
    │   ├── descriptions.txt
    │   ├── desc_1.rtf
    │   └── Files/
    │       └── notes.pdf
    │
    └── Database/
        ├── node.txt
        ├── hyperlinks.txt
        ├── descriptions.txt
        └── Files/
            └── sql_cheatsheet.txt
```

### Text File Format Specifications

1. **`Data/tree.txt`**:
   Stores the tree structure line-by-line:
   ```text
   # Format: NodeId|ParentId|NodeName|FolderName
   1||Programming|Programming
   2|1|Java|Java
   3|1|Python|Python
   4|1|C Programming|C_Programming
   5||Database|Database
   6|5|SQL|SQL
   7|5|MongoDB|MongoDB
   8||Operating Systems|Operating_Systems
   ```
   *ParentId is empty for root nodes, or set to the parent's NodeId for child nodes.*

2. **`Data/Nodes/{FolderName}/node.txt`**:
   ```text
   ID: 2
   Name: Java
   ParentID: 1
   Created: 2026-11-23 21:50:00
   ```

3. **`Data/Nodes/{FolderName}/hyperlinks.txt`**:
   ```text
   Language Reference|https://dev.java
   Oracle Docs|https://docs.oracle.com
   ```

4. **`Data/Nodes/{FolderName}/descriptions.txt`**:
   ```text
   desc_1.rtf|Course Module Notes
   desc_2.rtf|Syntax and Language Rules
   ```

5. **`Data/Nodes/{FolderName}/Files/`**:
   Stores copies of all uploaded files.

---

## 4. Project Structure

```
c:\Coding skills\
│
├── TreeCMS.sln                      <-- Visual Studio Solution File
├── README.md                        <-- Project Documentation & Viva Guide
│
└── TreeCMS/
    ├── TreeCMS.csproj               <-- C# Project File
    ├── App.config                   <-- Application Configuration (.NET 4.8)
    ├── Program.cs                   <-- Main Entry Point (Application.Run)
    │
    ├── Models/
    │   ├── NodeData.cs              <-- Node representation (Id, ParentId, Name, FolderName)
    │   ├── HyperlinkItem.cs         <-- Hyperlink entity (Title, URL)
    │   ├── DescriptionItem.cs       <-- Description metadata (FileName, Title)
    │   └── SearchResultItem.cs      <-- Search result model with breadcrumb path
    │
    ├── Services/
    │   ├── DataManager.cs           <-- File handling backend (File.ReadAllLines, File.WriteAllLines, etc.)
    │   └── SearchService.cs         <-- Universal search engine across nodes, links, descriptions, files
    │
    ├── Forms/
    │   ├── MainForm.cs              <-- Main UI logic, event handlers, CRUD workflows
    │   ├── MainForm.Designer.cs     <-- Windows Forms visual controls layout
    │   └── HyperlinkDialog.cs       <-- Modal dialog for adding/editing hyperlinks
    │
    └── Properties/
        └── AssemblyInfo.cs          <-- Application assembly metadata
```

---

## 5. How to Open, Build, and Run

### Method 1: Using Visual Studio 2026 / 2022
1. Open **Visual Studio 2026** or **Visual Studio 2022**.
2. Click **Open a project or solution**.
3. Select `TreeCMS.sln` from `c:\Coding skills\`.
4. Set the build configuration to **Debug** or **Release** and platform to **Any CPU**.
5. Press **F5** (or click the green **Start** button) to build and launch the application.

### Method 2: Building via Command Line (MSBuild)
You can build the solution from Developer Command Prompt or PowerShell:
```powershell
& "C:\Windows\Microsoft.NET\Framework64\v4.0.30319\MSBuild.exe" "c:\Coding skills\TreeCMS.sln" /p:Configuration=Release
```
The compiled executable will be located at:
`c:\Coding skills\TreeCMS\bin\Release\TreeCMS.exe`

---

## 6. Key Features and Implementation Details

### A. TreeView and Node Management
- **Add Root Node:** Prompts for node name, generates a unique Node ID, creates a corresponding storage folder, writes `node.txt`, and updates `tree.txt`.
- **Add Child Node:** Adds a subcategory under the currently selected node using the selected node's ID as `ParentId`.
- **Update Node:** Renames the selected node in TreeView, updates `node.txt`, and updates `tree.txt`.
- **Delete Node:** Displays a warning confirmation message. Upon confirmation, recursively collects all descendant nodes, deletes all their files and folders on disk via `Directory.Delete(dirPath, true)`, removes the nodes from TreeView, and updates `tree.txt`.
- **Expand / Collapse All:** Quick buttons to expand or collapse the entire tree structure.

### B. Hyperlink Management
- Displays all hyperlinks in a structured `ListView` (Title, URL).
- **Add:** Inputs Title and URL with automated protocol prefixing (`https://` if missing).
- **Edit:** Modifies existing links.
- **Delete:** Removes link with confirmation.
- **Open in Browser:** Launches `Process.Start(new ProcessStartInfo(url) { UseShellExecute = true });`.

### C. File Upload and Local Storage
- **Browse & Upload:** Uses `OpenFileDialog` with `Multiselect = true` allowing multiple file selection.
- Supported extensions: PDF, Word documents (.docx, .doc), text files (.txt), images (.png, .jpg), and all other formats.
- Files are copied into `Data/Nodes/{FolderName}/Files/` using `File.Copy(source, target, true)`.
- **Display:** Shows File Name, Extension, File Size (in bytes), and Date Modified.
- **Open File:** Launches the file in its default registered application via `Process.Start`.
- **Delete File:** Permanently deletes the file from disk using `File.Delete`.

### D. Rich-Text Descriptions
- Multiple descriptions per category node.
- Left subpanel lists description titles; right panel provides an interactive formatting editor.
- **Formatting Toolbar:**
  - **Bold (B)**, **Italic (I)**, **Underline (U)** toggle buttons.
  - **Font Family** selector (Segoe UI, Arial, Calibri, Consolas, Times New Roman, etc.).
  - **Font Size** dropdown (9 to 28 pt).
  - **Color Picker** via `ColorDialog`.
  - **Bullet Points** toggle via `RichTextBox.SelectionBullet`.
- Saves formatting using `RichTextBox.SaveFile(path, RichTextBoxStreamType.RichText)` and reloads via `RichTextBox.LoadFile()`.

### E. Universal Keyword Search
- Case-insensitive search evaluated across:
  1. Node names
  2. Hyperlinks (Title and URL)
  3. Description text (Title and plain-text body content)
  4. Uploaded filenames
- Results panel displays matching items along with their category, matching text, and full breadcrumb path (e.g., `Programming > Java`).
- **One-Click Navigation:** Double-clicking any search result automatically selects that node in the TreeView, expands parent nodes, and switches to the relevant tab.

---

## 7. Error Handling and Validation

- **Empty Node Names:** Prevents creation of empty or whitespace-only nodes with an informative `MessageBox`.
- **Missing Selection:** Informs the user when an action requires selecting a node or item first.
- **URL Validation:** Automatically prepends `https://` if the user enters a web address without protocol.
- **File System Protection:** All file and directory operations are wrapped in `try ... catch` blocks to gracefully display errors if a file is locked or missing.
- **Deletion Safeguards:** Confirmation dialogs before deleting nodes, files, hyperlinks, or descriptions.

---

## 8. Faculty Viva Preparation (Questions & Answers)

### Q1: Why did you choose a text-file backend instead of a relational database like SQL Server or SQLite?
> **Answer:** The objective of this project is to demonstrate core C# programming, file handling using the `System.IO` namespace, string manipulation, and Windows Forms UI design. A flat text-file architecture keeps the application lightweight, fully portable (no database installation or connection strings required), human-readable, and allows easy inspection of stored data directly in Notepad.

### Q2: How is the hierarchical tree structure stored and reconstructed from a flat text file (`tree.txt`)?
> **Answer:** In `tree.txt`, each record contains four fields: `NodeId|ParentId|NodeName|FolderName`.
> When the application loads, `DataManager.LoadAllNodes()` reads this file line-by-line using `File.ReadAllLines()`.
> In the first pass, a `TreeNode` object is instantiated for each record and stored in a dictionary keyed by `NodeId`.
> In the second pass, if a node has a non-empty `ParentId`, it is attached as a child to `dict[ParentId].Nodes.Add(childNode)`. If `ParentId` is empty, it is added to the root of the `TreeView`. This reconstructs any arbitrary n-level tree hierarchy in $O(N)$ time.

### Q3: What happens when a parent node is deleted?
> **Answer:** We perform a recursive traversal (`CollectDescendants`) starting from the selected node's `Id` to identify all child and grandchild nodes. We then call `Directory.Delete(nodeFolderPath, true)` to remove each node's directory and its contents from the disk, remove the records from our in-memory list, rewrite `tree.txt`, and remove the `TreeNode` from the `TreeView`.

### Q4: How is Rich Text formatting preserved in text files?
> **Answer:** We utilize the Windows Forms `RichTextBox` control. Instead of saving plain text, we save the content as RTF (Rich Text Format) using `rtbDescriptionContent.Rtf` into an individual `.rtf` file. RTF uses ASCII-based formatting codes (e.g., `\b` for bold, `\i` for italic, `\cf` for color). When the user selects a description, we assign the file contents back to `rtbDescriptionContent.Rtf`, which restores the formatting.

### Q5: How does the application launch web links and open uploaded files in default programs?
> **Answer:** We use the `System.Diagnostics.Process.Start()` API with `ProcessStartInfo.UseShellExecute = true`. When passed a URL (e.g., `https://dev.java`), the Windows shell invokes the default web browser (Chrome, Edge, Firefox). When passed a local file path (e.g., `notes.pdf`), Windows launches the registered default application (such as Adobe Reader or default PDF viewer).

### Q6: How does the keyword search engine work across different content types?
> **Answer:** The `SearchService` class iterates through all nodes and performs case-insensitive comparisons using `source.IndexOf(keyword, StringComparison.OrdinalIgnoreCase) >= 0`. It checks the node's name, iterates through its list of `HyperlinkItem` objects, inspects `DescriptionItem` titles and RTF bodies (stripping RTF markup to extract readable text), and inspects the names of all files in the node's `Files/` directory.

### Q7: What basic `System.IO` methods did you use in the project?
> **Answer:**
> - `File.ReadAllLines()` and `File.WriteAllLines()` for `tree.txt` and `hyperlinks.txt`.
> - `File.ReadAllText()` and `File.WriteAllText()` for `node.txt` and description files.
> - `Directory.CreateDirectory()` for creating node folders and `Files/` subdirectories.
> - `Directory.Delete(path, true)` for recursive folder cleanup on node deletion.
> - `File.Copy(source, target, true)` for uploading files into local node storage.
> - `File.Delete(path)` for removing uploaded files.
> - `File.Exists()` and `Directory.Exists()` for safety checks before I/O.

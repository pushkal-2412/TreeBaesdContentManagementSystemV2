# Tree-Based Content Management System (TreeCMS) - Version 2
## Coding Skills 2 – Desktop Application Project (V2)

A desktop content management system developed in **C#** and **Windows Forms (WinForms)** for **Visual Studio 2026 / 2022**. The application organizes content into categories and subcategories using a hierarchical tree structure, backed entirely by a **simple text-file and local directory storage system** without databases, complex architectures, or external APIs.

### 🌟 New in Version 2 (Faculty Requested Features):
- **Right-Click Context Menu on TreeView Nodes:**
  - **Add Child Node**: Directly adds a subcategory under the right-clicked node.
  - **Rename Node**: Quickly prompts to rename the right-clicked node.
  - **Delete Node**: Prompts for confirmation and deletes the node and all sub-content.
- **Right-Click on Empty TreeView Space:**
  - Automatically displays **Add Root Node** to easily create a new top-level category anywhere in the tree view area.


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


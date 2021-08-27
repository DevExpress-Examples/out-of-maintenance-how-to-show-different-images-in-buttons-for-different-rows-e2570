<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128631700/10.1.4%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E2570)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [DifferentButtonIconsHelper.cs](./CS/Classes/DifferentButtonIconsHelper.cs) (VB: [DifferentButtonIconsHelper.vb](./VB/Classes/DifferentButtonIconsHelper.vb))
* [DirectoryHelper.cs](./CS/Classes/DirectoryHelper.cs) (VB: [DirectoryHelper.vb](./VB/Classes/DirectoryHelper.vb))
* [GetButtonIndexEventArgs.cs](./CS/Classes/GetButtonIndexEventArgs.cs) (VB: [GetButtonIndexEventArgs.vb](./VB/Classes/GetButtonIndexEventArgs.vb))
* [GridExplorerHelper.cs](./CS/Classes/GridExplorerHelper.cs) (VB: [GridExplorerHelper.vb](./VB/Classes/GridExplorerHelper.vb))
* [GridFile.cs](./CS/Classes/GridFile.cs) (VB: [GridFile.vb](./VB/Classes/GridFile.vb))
* [Form1.cs](./CS/Form1.cs) (VB: [Form1.vb](./VB/Form1.vb))
* [Program.cs](./CS/Program.cs) (VB: [Program.vb](./VB/Program.vb))
<!-- default file list end -->
# How to show different images in buttons for different rows


<p>Usually, different editors should be provided via the  <a href="http://documentation.devexpress.com/#WindowsForms/DevExpressXtraGridViewsGridGridView_CustomRowCellEditForEditingtopic">GridView.CustomRowCellEditForEditing</a>  event. (For more information, please see the  <a href="http://documentation.devexpress.com/#WindowsForms/CustomDocument747">Assigning Editors to Individual Cells</a>  help topic.)</p><p>However, when you need to show many various icons in buttons for inplace ButtonEdits, this approach is not the best solution, because you need to implement a custom caching mechanism to prevent creating duplicate RepositoryItems. </p><p>This example demonstrates how to create a helper class which provides images for cells dynamically, via an event. In this case, you do not need to create additional RepositoryItems. You just need to copy required units to your project and create an instance of the DifferentButtonIconsHelper class.</p>

<br/>



<!-- default badges list -->
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E2086)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [Window1.xaml](./CS/Window1.xaml) (VB: [Window1.xaml](./VB/Window1.xaml))
* **[Window1.xaml.cs](./CS/Window1.xaml.cs) (VB: [Window1.xaml.vb](./VB/Window1.xaml.vb))**
<!-- default file list end -->
# How to invoke standard XtraReports Print Preview and End-User Designer in a WPF application


<p>The following example demonstrates how to preview and edit reports, created by the XtraReports suite, in a WPF application.<br /><br /><strong>Important note: </strong>the use of this example requires the WinForms part of our Reporting tools that is not included into WPF subscription. If you wish to use this functionality, it is required to own WinForms, Reporting, DXperience, or Universal subscription.</p>


<h3>Description</h3>

<p>In this example, an XtraReport class descendant has been added to a WPF application. This report contains two simple labels, which display data from a report&#39;s datasource populated from the Contacts.mdb file on a local disk.</p><p>To display a report&#39;s Print Preview, it is necessary to call the XtraReport.ShowPreview or ShowPreviewDialog method in a window&#39;s code behind. To run the End-User Designer for a report, it is necessary to call the XtraReport.ShowDesigner or ShowDesignerDialog method.</p>

<br/>



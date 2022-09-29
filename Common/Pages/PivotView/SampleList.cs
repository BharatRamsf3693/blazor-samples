#region Copyright Syncfusion Inc. 2001-2022.
// Copyright Syncfusion Inc. 2001-2022. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlazorDemos;
namespace BlazorDemos
{
    internal partial class SampleConfig
    {
        public List<Sample> PivotTable { get; set; } = new List<Sample>{
            new Sample
            {
                Name = "Default Functionalities",
                Category = "Pivot Table",
                Directory = "PivotView/PivotTable",
                Url = "pivot-table/default-functionalities",
                FileName = "DefaultFunctionalities.razor",
                MetaTitle = "Blazor Pivot Table Example | Default Functionalities | Syncfusion Demos",
                HeaderText = "Blazor Pivot Table Example - Default Functionalities",
                MetaDescription = "This Blazor Pivot Table example demonstrates the default rendering of the Blazor Pivot Table component with a minimum configuration. Explore here for more details.",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Local Data",
                Category = "Data Binding",
                Directory = "PivotView/PivotTable",
                Url = "pivot-table/local-data",
                FileName = "LocalData.razor",
                MetaTitle = "Blazor Pivot Table Example | Local Data | Syncfusion Demos",
                HeaderText = "Blazor Pivot Table Example - Local Data",
                MetaDescription = "This Blazor Pivot Table example demonstrates the default rendering of the Blazor Pivot Table component with a minimum configuration. Explore here for more details.",
                NotificationDescription = new string[] { @"Added a demo for rendering the Pivot Table component using JSON or CSV local file." },
                Type = SampleType.New
            },
            new Sample
            {
                Name = "Remote Data",
                Category = "Data Binding",
                Directory = "PivotView/PivotTable",
                Url = "pivot-table/remote-data",
                FileName = "RemoteData.razor",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "OLAP",
                Category = "Data Binding",
                Directory = "PivotView/PivotTable",
                Url = "pivot-table/olap",
                FileName = "OLAP.razor",
                Type = SampleType.None,
            },
            new Sample
            {
                Name = "Pivot Chart",
                Category = "Integration",
                Directory = "PivotView/PivotTable",
                Url = "pivot-table/pivot-chart",
                FileName = "Chart.razor",
                Type = SampleType.None,
            },
            // new Sample
            //{
            //    Name = "External Binding",
            //    Category = "Integration",
            //    Directory = "PivotView/PivotTable",
            //    Url = "pivot-table/external-binding",
            //    FileName = "ExternalBinding.razor",
            //    Type = SampleType.New,
            //    NotificationDescription = new string[] { @"Added a demo to create and update the Heatmap component using the cell selection obtained from the Pivot Table UI." }
            //},
            new Sample
            {
                Name = "Field List",
                Category = "User Interaction",
                Directory = "PivotView/PivotTable",
                Url = "pivot-table/field-list",
                FileName = "FieldList.razor",
                Type = SampleType.Updated,
                NotificationDescription = new string[] { @"The demo has been updated to show the build-in field list popup UI for mobile mode." },
            },
            new Sample
            {
                Name = "Grouping Bar",
                Category = "User Interaction",
                Directory = "PivotView/PivotTable",
                Url = "pivot-table/grouping-bar",
                FileName = "GroupingBar.razor",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Conditional Formatting",
                Category = "User Interaction",
                Directory = "PivotView/PivotTable",
                Url = "pivot-table/conditional-formatting",
                FileName = "ConditionalFormatting.razor",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Selection",
                Category = "User Interaction",
                Directory = "PivotView/PivotTable",
                Url = "pivot-table/selection",
                FileName = "Selection.razor",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Drill Down",
                Category = "User Interaction",
                Directory = "PivotView/PivotTable",
                Url = "pivot-table/drill-down",
                FileName = "DrillDown.razor",                
                Type = SampleType.New,
                NotificationDescription = new string[] { @"Added a demo to display the Pivot Table with various drill-down options based on headers or fields." }
            },
            new Sample
            {
                Name = "Show/Hide Totals",
                Category = "User Interaction",
                Directory = "PivotView/PivotTable",
                Url = "pivot-table/show-hide-totals",
                FileName = "SummaryCustomization.razor",
                Type = SampleType.Updated,
                NotificationDescription = new string[] { @"The demo has been updated to display the grand totals either at top or bottom of the Pivot Table."}
            },
            new Sample
            {
                Name = "Grouping",
                Category = "User Interaction",
                Directory = "PivotView/PivotTable",
                Url = "pivot-table/grouping",
                FileName = "Grouping.razor",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Toolbar",
                Category = "User Interaction",
                Directory = "PivotView/PivotTable",
                Url = "pivot-table/toolbar",
                FileName = "Toolbar.razor",
                Type = SampleType.None
            },            
            new Sample
            {
                Name="Keyboard Navigation",
                Category="Keyboard Navigation",
                Directory = "PivotView/PivotTable",
                Url="pivot-table/keyboard-navigation",
                FileName="PivotKeyboard.razor",
                Type=SampleType.None
            },
            new Sample
            {
                Name = "Calculated Field",
                Category = "Formula",
                Directory = "PivotView/PivotTable",
                Url = "pivot-table/calculated-field",
                FileName = "CalculatedField.razor",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Aggregation",
                Category = "Formula",
                Directory = "PivotView/PivotTable",
                Url = "pivot-table/aggregation",
                FileName = "Aggregation.razor",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Default Sorting",
                Category = "Sorting",
                Directory = "PivotView/PivotTable",
                Url = "pivot-table/default-sorting",
                FileName = "DefaultSorting.razor"
            },
            new Sample
            {
                Name = "Value Sorting",
                Category = "Sorting",
                Directory = "PivotView/PivotTable",
                Url = "pivot-table/value-sorting",
                FileName = "ValueSorting.razor",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Default Filtering",
                Category = "Filtering",
                Directory = "PivotView/PivotTable",
                Url = "pivot-table/default-filtering",
                FileName = "MemberFiltering.razor",
                Type = SampleType.Updated,
                NotificationDescription = new string[] { @"The demo has been updated to show the various options that can be used to apply member filtering in the Pivot Table." }
            },
            new Sample
            {
                Name = "Label Filtering",
                Category = "Filtering",
                Directory = "PivotView/PivotTable",
                Url = "pivot-table/label-filtering",
                FileName = "LabelFiltering.razor",
                Type = SampleType.Updated,
                NotificationDescription = new string[] { @"The demo has been updated to show the various options that can be used to apply label filtering in the Pivot Table."}
            },
            new Sample
            {
                Name = "Value Filtering",
                Category = "Filtering",
                Directory = "PivotView/PivotTable",
                Url = "pivot-table/value-filtering",
                FileName = "ValueFiltering.razor",
                Type = SampleType.Updated,
                NotificationDescription = new string[] { @"The demo has been updated to show the various options that can be used to apply value filtering in the Pivot Table."}
            },
            new Sample
            {
                Name = "Virtual Scrolling",
                Category = "Scrolling",
                Directory = "PivotView/PivotTable",
                Url = "pivot-table/virtual-scrolling",
                FileName = "VirtualScrolling.razor",
                Type = SampleType.Updated,
                NotificationDescription = new string[] { @"The demo has been updated to show how long it takes to load 100k raw data into the Pivot Table."}
            },
            new Sample
            {
                Name = "Cell Template",
                Category = "Customization",
                Directory = "PivotView/PivotTable",
                Url = "pivot-table/cell-template",
                FileName = "PivotCellTemplate.razor",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Drill Through",
                Category = "Miscellaneous",
                Directory = "PivotView/PivotTable",
                Url = "pivot-table/drill-through",
                FileName = "DrillThrough.razor",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Editing",
                Category = "Miscellaneous",
                Directory = "PivotView/PivotTable",
                Url = "pivot-table/editing",
                FileName = "Editing.razor",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Hyperlink",
                Category = "Miscellaneous",
                Directory = "PivotView/PivotTable",
                Url = "pivot-table/hyperlink",
                FileName = "HyperLink.razor",
                Type = SampleType.Updated,
                NotificationDescription = new string[] { @"The demo has been updated to show the various hyperlink options available in the Pivot Table, as well as an event trace."}
            },
            new Sample
            {
                Name = "Defer Layout Update",
                Category = "Miscellaneous",
                Directory = "PivotView/PivotTable",
                Url = "pivot-table/defer-layout-update",
                FileName = "DeferUpdate.razor",
                Type = SampleType.Updated,
                NotificationDescription = new string[] { @"The demo has been updated to show the build-in field list popup UI for mobile mode." }
            },
            new Sample
            {
                Name = "Export",
                Category = "Miscellaneous",
                Directory = "PivotView/PivotTable",
                Url = "pivot-table/export",
                FileName = "Exporting.razor"
            }            
        };
    }
}

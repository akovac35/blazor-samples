﻿﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ej2_blazor_samples
{
    internal partial class SampleConfig
    {
      
        internal SampleConfig()
        {
            SampleBrowser.SampleList.Add(new SampleList
            {
                Name = "DataGrid",
                Category = "Grids",
                Directory = "Grid",
                Type = SampleType.None,
                UID = 002,
                Order = 01,
                Samples = DataGrid,
                ControllerName = "Grid"
            });
            SampleBrowser.SampleList.Add(new SampleList
            {
                Name = "TreeGrid",
                Category = "Grids",
                Directory = "TreeGrid/TreeGrid",
                Type = SampleType.None,
                UID = 006,
                Order = 02,
                Samples = TreeGrid,
                ControllerName = "TreeGrid"
            });
            SampleBrowser.SampleList.Add(new SampleList
            {
                Name = "PivotTable",
                Category = "Grids",
                Directory = "PivotView/PivotTable",
                Type = SampleType.None,
                UID = 027,
                Order = 03,
                Samples = PivotTable,
                ControllerName = "PivotTable"
            });
            SampleBrowser.SampleList.Add(new SampleList
            {
                Name = "Chart",
                Category = "Data Visualization",
                Directory = "Charts",
                Type = SampleType.None,
                UID = 005,
                Order = 01,
                Samples = Chart,
                ControllerName = "Charts"
            });
            SampleBrowser.SampleList.Add(new SampleList
            {
                Name = "StockChart",
                Category = "Data Visualization",
                Directory = "Charts",
                Type = SampleType.None,
                UID = 006,
                Order = 01,
                Samples = StockChart,
                ControllerName = "StockChart"
            });
            SampleBrowser.SampleList.Add(new SampleList
            {
                Name = "BulletChart",
                Category = "Data Visualization",
                Directory = "Charts",
                Type = SampleType.Preview,
                UID = 029,
                Order = 01,
                Samples = BulletChart,
                ControllerName = "BulletChart"
            });
            SampleBrowser.SampleList.Add(new SampleList
            {
                Name = "CircularGauge",
                Category = "Data Visualization",
                Directory = "CircularGauge",
                Type = SampleType.None,
                UID = 003,
                Order = 03,
                Samples = CircularGauge,
                ControllerName = "CircularGauge"
            });
            SampleBrowser.SampleList.Add(new SampleList
            {
                Name = "LinearGauge",
                Category = "Data Visualization",
                Directory = "LinearGauge/LinearGauge",
                Type = SampleType.None,
                UID = 004,
                Order = 04,
                Samples = LinearGauge,
                ControllerName = "LinearGauge"
            });
            SampleBrowser.SampleList.Add(new SampleList
            {
                Name = "Diagram",
                Category = "Data Visualization",
                Directory = "Diagrams",
                Type = SampleType.Preview,
                UID = 005,
                Order = 05,
                Samples = Diagram,
                ControllerName = "Diagrams"
            });
            SampleBrowser.SampleList.Add(new SampleList
            {
                Name = "Sparkline",
                Category = "Data Visualization",
                Directory = "Charts/Sparkline",
                Type = SampleType.None,
                UID = 010,
                Order = 10,
                Samples = Sparkline,
                ControllerName = "Sparkline"
            });
            SampleBrowser.SampleList.Add(new SampleList
            {
                Name = "TreeMap",
                Category = "Data Visualization",
                Directory = "TreeMap/TreeMap",
                Type = SampleType.None,
                UID = 011,
                Order = 11,
                Samples = TreeMap,
                ControllerName = "TreeMap"
            });
            SampleBrowser.SampleList.Add(new SampleList
            {
                Name = "Maps",
                Category = "Data Visualization",
                Directory = "Maps/Maps",
                Type = SampleType.None,
                UID = 007,
                Order = 07,
                Samples = Maps,
                ControllerName = "Maps"
            });
            SampleBrowser.SampleList.Add(new SampleList
            {
                Name = "RangeNavigator",
                Category = "Data Visualization",
                Directory = "Charts",
                Type = SampleType.None,
                UID = 006,
                Order = 01,
                Samples = RangeNavigator,
                ControllerName = "RangeSelector"
            });
            SampleBrowser.SampleList.Add(new SampleList
            {
                Name = "SmithChart",
                Category = "Data Visualization",
                Directory = "Charts/RangeNavigator",
                Type = SampleType.None,
                UID = 009,
                Order = 09,
                Samples = SmithChart,
                ControllerName = "SmithChart"
            });
            SampleBrowser.SampleList.Add(new SampleList
            {
                Name = "Barcode",
                Category = "Data Visualization",
                Directory = "Barcodes",
                Type = SampleType.None,
                UID = 005,
                Order = 05,
                Samples = Barcode,
                ControllerName = "Barcodes"
            });
            SampleBrowser.SampleList.Add(new SampleList
            {
                Name = "Button",
                Category = "Editors",
                Directory = "Buttons",
                Type = SampleType.None,
                UID = 003,
                Order = 03,
                Samples = Button,
                ControllerName = "Buttons"
            });
            SampleBrowser.SampleList.Add(new SampleList
            {
                Name = "Calendar",
                Category = "Calendars",
                Directory = "Calendars/Calendar",
                Type = SampleType.None,
                UID = 014,
                Order = 02,
                Samples = Calendar,
                ControllerName = "Calendar"
            });
            SampleBrowser.SampleList.Add(new SampleList
            {
                Name = "DatePicker",
                Category = "Calendars",
                Directory = "Calendars/DatePicker",
                Type = SampleType.None,
                UID = 015,
                Order = 03,
                Samples = DatePicker,
                ControllerName = "DatePicker"
            });
            SampleBrowser.SampleList.Add(new SampleList
            {
                Name = "DateTimePicker",
                Category = "Calendars",
                Directory = "Calendars/DateTimePicker",
                Type = SampleType.Preview,
                UID = 016,
                Order = 06,
                Samples = DateTimePicker,
                ControllerName = "DateTimePicker"
            });
            SampleBrowser.SampleList.Add(new SampleList
            {
                Name = "TimePicker",
                Category = "Calendars",
                Directory = "Calendars/TimePicker",
                Type = SampleType.Preview,
                UID = 017,
                Order = 17,
                Samples = TimePicker,
                ControllerName = "TimePicker"
            });
            SampleBrowser.SampleList.Add(new SampleList
            {
                Name = "DateRangePicker",
                Category = "Calendars",
                Directory = "Calendars/DateRangePicker",
                Type = SampleType.Preview,
                UID = 018,
                Order = 04,
                Samples = DateRangePicker,
                ControllerName = "DateRangePicker"
            });
            SampleBrowser.SampleList.Add(new SampleList
            {
                Name = "DropDownList",
                Category = "DropDowns",
                Directory = "DropDowns/DropDownList",
                Type = SampleType.None,
                UID = 019,
                Order = 03,
                Samples = DropDownList,
                ControllerName = "DropDownList"
            });
            SampleBrowser.SampleList.Add(new SampleList
            {
                Name = "ComboBox",
                Category = "DropDowns",
                Directory = "DropDowns/ComboBox",
                Type = SampleType.Preview,
                UID = 020,
                Order = 02,
                Samples = ComboBox,
                ControllerName = "ComboBox"
            });
            SampleBrowser.SampleList.Add(new SampleList
            {
                Name = "AutoComplete",
                Category = "DropDowns",
                Directory = "DropDowns/AutoComplete",
                Type = SampleType.Preview,
                UID = 021,
                Order = 01,
                Samples = AutoComplete,
                ControllerName = "AutoComplete"
            });
            SampleBrowser.SampleList.Add(new SampleList
            {
                Name = "MultiSelect",
                Category = "DropDowns",
                Directory = "DropDowns/MultiSelect",
                Type = SampleType.Preview,
                UID = 022,
                Order = 04,
                Samples = MultiSelect,
                ControllerName = "MultiSelect"
            });
            SampleBrowser.SampleList.Add(new SampleList
            {
                Name = "ListBox",
                Category = "DropDowns",
                Directory = "DropDowns/ListBox",
                Type = SampleType.Preview,
                UID = 028,
                Order = 05,
                Samples = ListBox,
                ControllerName = "ListBox"
            });
            SampleBrowser.SampleList.Add(new SampleList
            {
                Name = "Sidebar",
                Category = "Navigations",
                Directory = "Navigations/Sidebar",
                Type = SampleType.None,
                UID = 005,
                Order = 04,
                Samples = Sidebar,
                ControllerName = "Sidebar"
            });
            SampleBrowser.SampleList.Add(new SampleList
            {
                Name = "Accordion",
                Category = "Navigations",
                Directory = "Navigations/Accordion",
                Type = SampleType.Preview,
                UID = 005,
                Order = 01,
                Samples = Accordion,
                ControllerName = "Accordion"
            });
            SampleBrowser.SampleList.Add(new SampleList
            {
                Name = "Toolbar",
                Category = "Navigations",
                Directory = "Navigations/Toolbar",
                Type = SampleType.None,
                UID = 005,
                Order = 06,
                Samples = Toolbar,
                ControllerName = "Toolbar"
            });
            SampleBrowser.SampleList.Add(new SampleList
            {
                Name = "Tab",
                Category = "Navigations",
                Directory = "Navigations/Tab",
                Type = SampleType.None,
                UID = 005,
                Order = 05,
                Samples = Tab,
                ControllerName = "Tab"
            });
            SampleBrowser.SampleList.Add(new SampleList
            {
                Name = "Toast",
                Category = "Notifications",
                Directory = "Notifications/Toast",
                Type = SampleType.Preview,
                UID = 016,
                Order = 16,
                Samples = Toast,
                ControllerName = "Toast"
            });
            SampleBrowser.SampleList.Add(new SampleList
            {
                Name = "Spinner",
                Category = "Notifications",
                Directory = "Notifications/Spinner",
                Type = SampleType.None,
                UID = 011,
                Order = 02,
                Samples = Spinner,
                ControllerName = "Spinner"
            });
            SampleBrowser.SampleList.Add(new SampleList
            {
                Name = "TextBox",
                Category = "Inputs",
                Directory = "Inputs",
                Type = SampleType.None,
                UID = 004,
                Order = 01,
                Samples = TextBox,
                ControllerName = "TextBox"
            });
            SampleBrowser.SampleList.Add(new SampleList
            {
                Name = "DashboardLayout",
                Category = "Layout",
                Directory = "Layouts/DashboardLayout",
                Type = SampleType.None,
                UID = 028,
                Order = 01,
                Samples = DashboardLayout,
                ControllerName = "DashboardLayout"
            });
            SampleBrowser.SampleList.Add(new SampleList
            {
                Name = "Dialog",
                Category = "Layout",
                Directory = "Popups/Dialog",
                Type = SampleType.None,
                UID = 008,
                Order = 02,
                Samples = Dialog,
                ControllerName = "Dialog"
            });
            SampleBrowser.SampleList.Add(new SampleList
            {
                Name = "Listview",
                Category = "Layout",
                Directory = "Layouts/Listview",
                Type = SampleType.Preview,
                UID = 005,
                Order = 01,
                Samples = Listview,
                ControllerName = "Listview"
            });
            SampleBrowser.SampleList.Add(new SampleList
            {
                Name = "Tooltip",
                Category = "Layout",
                Directory = "Layouts/Tooltip",
                Type = SampleType.None,
                UID = 022,
                Order = 22,
                Samples = Tooltip,
                ControllerName = "Tooltip"
            });
            SampleBrowser.SampleList.Add(new SampleList
            {
                Name = "Splitter",
                Category = "Layout",
                Directory = "Layouts/Splitter",
                Type = SampleType.Preview,
                UID = 010,
                Order = 10,
                Samples = Splitter,
                ControllerName = "Splitter"
            });
            SampleBrowser.SampleList.Add(new SampleList
            {
                Name = "QueryBuilder",
                Category = "Forms",
                Directory = "Forms/QueryBuilder",
                Type = SampleType.Preview,
                UID = 026,
                Order = 26,
                Samples = QueryBuilder,
                ControllerName = "QueryBuilder"
            });
            SampleBrowser.SampleList.Add(new SampleList
            {
                Name = "PdfViewer",
                Category = "Viewer",
                Directory = "Viewer",
                Type = SampleType.None,
                UID = 006,
                Order = 04,
                Samples = PdfViewer,
                ControllerName = "Viewer"
            });

            SampleBrowser.SampleList.Add(new SampleList
            {
                Name = "DocumentEditor",
                Category = "Editors",
                Directory = "DocumentEditor/DocumentEditor",
                Type = SampleType.None,
                UID = 004,
                Order = 02,
                Samples = DocumentEditor,
                ControllerName = "DocumentEditor"
            });
            SampleBrowser.SampleList.Add(new SampleList
            {
                Name = "InPlaceEditor",
                Category = "Editors",
                Directory = "Editors/InPlaceEditor",
                Type = SampleType.None,
                UID = 009,
                Order = 09,
                Samples = InPlaceEditor,
                ControllerName = "Editors"
            });
            SampleBrowser.SampleList.Add(new SampleList
            {
                Name = "Schedule",
                Category = "Calendars",
                Directory = "Schedule/Schedule",
                Type = SampleType.None,
                UID = 005,
                Order = 01,
                Samples = Schedule,
                ControllerName = "Schedule"
            });
            SampleBrowser.SampleList.Add(new SampleList
            {
                Name = "Gantt",
                Category = "Calendars",
                Directory = "Gantt/Gantt",
                Type = SampleType.Preview,
                UID = 005,
                Order = 01,
                Samples = Gantt,
                ControllerName = "Gantt"
            });
            SampleBrowser.SampleList.Add(new SampleList
            {
                Name = "RichTextEditor",
                Category = "Editors",
                Directory = "RichTextEditor/RichTextEditor",
                Type = SampleType.None,
                UID = 005,
                Order = 01,
                Samples = RichTextEditor,
                ControllerName = "RichTextEditor"
            });
            SampleBrowser.SampleList.Add(new SampleList
            {
                Name = "NumericTextBox",
                Category = "Inputs",
                Directory = "Inputs/NumericTextBox",
                Type = SampleType.None,
                UID = 011,
                Order = 03,
                Samples = NumericTextBox,
                ControllerName = "NumericTextBox"
            });
            SampleBrowser.SampleList.Add(new SampleList
            {
                Name = "MaskedTextBox",
                Category = "Inputs",
                Directory = "Inputs/MaskedTextBox",
                Type = SampleType.Preview,
                UID = 012,
                Order = 02,
                Samples = MaskedTextBox,
                ControllerName = "MaskedTextBox"
            });
            SampleBrowser.SampleList.Add(new SampleList
            {
                Name = "FileUpload",
                Category = "Inputs",
                Directory = "Inputs/Uploader",
                Type = SampleType.Preview,
                UID = 013,
                Order = 05,
                Samples = FileUpload,
                ControllerName = "Uploader"
            });
            SampleBrowser.SampleList.Add(new SampleList
            {
                Name = "ColorPicker",
                Category = "Inputs",
                Directory = "Inputs/ColorPicker",
                Type = SampleType.Preview,
                UID = 023,
                Order = 04,
                Samples = ColorPicker,
                ControllerName = "ColorPicker"
            });
            SampleBrowser.SampleList.Add(new SampleList
            {
                Name = "ContextMenu",
                Category = "Navigations",
                Directory = "Navigations/ContextMenu",
                Type = SampleType.Preview,
                UID = 024,
                Order = 02,
                Samples = ContextMenu,
                ControllerName = "ContextMenu"
            });
            SampleBrowser.SampleList.Add(new SampleList
            {
                Name = "MenuBar",
                Category = "Navigations",
                Directory = "Navigations/MenuBar",
                Type = SampleType.Preview,
                UID = 025,
                Order = 03,
                Samples = MenuBar,
                ControllerName = "MenuBar"
            });
            SampleBrowser.SampleList.Add(new SampleList
            {
                Name = "HeatMapChart",
                Category = "Data Visualization",
                Directory = "HeatMapChart/HeatMapChart",
                Type = SampleType.None,
                UID = 006,
                Order = 06,
                Samples = HeatMapChart,
                ControllerName = "HeatMapChart"
            });
            SampleBrowser.SampleList.Add(new SampleList
            {
                Name = "Chips",
                Category = "Editors",
                Directory = "Buttons/Chips",
                Type = SampleType.None,
                UID = 004,
                Order = 03,
                Samples = Chips,
                ControllerName = "Chips"
            });
            SampleBrowser.SampleList.Add(new SampleList
            {
                Name = "TreeView",
                Category = "Navigations",
                Directory = "Navigations/TreeView",
                Type = SampleType.Preview,
                UID = 015,
                Order = 15,
                Samples = TreeView,
                ControllerName = "TreeView"
            });
            SampleBrowser.SampleList.Add(new SampleList
            {
                Name = "Slider",
                Category = "Inputs",
                Directory = "Inputs/Slider",
                Type = SampleType.Preview,
                UID = 014,
                Order = 14,
                Samples = Slider,
                ControllerName = "Slider"
            });
            SampleBrowser.SampleList.Add(new SampleList
            {
                Name = "FileManager",
                Category = "Navigations",
                Directory = "Navigations/FileManager",
                Type = SampleType.Preview,
                UID = 016,
                Order = 04,
                Samples = FileManager,
                ControllerName = "FileManager"
            });
        }
    }
}

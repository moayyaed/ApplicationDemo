﻿namespace Application
{
    using Framework.Server.Application;
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Framework.Server.Application.Json;

    public class ApplicationServer : ApplicationServerBase
    {
        protected override void ApplicationJsonInit(ApplicationJson applicationJson)
        {
            new GridKeyboard(applicationJson, "GridKeyboard");
            var container = new LayoutContainer(applicationJson, "Container") { Class = "co" };
            var rowLogo = new LayoutRow(container, "RowLogo") { Class = "r" };
            var literalLogo = new Literal(rowLogo, "Logo");
            literalLogo.Html = "<img src='Logo.png' />";
            var rowHeader = new LayoutRow(container, "Header") { Class = "r" };
            var cellHeader1 = new LayoutCell(rowHeader, "HeaderCell1") { Class = "c" };
            new GridField(cellHeader1, "Field", null, null, null);
            var cellHeader2 = new LayoutCell(rowHeader, "HeaderCell2") { Class = "c" };
            new Grid(cellHeader2, "LookUp", "LookUp");
            var rowHeader2 = new LayoutRow(container, "Header") { Class = "r" };
            var cellHeader3 = new LayoutCell(rowHeader, "HeaderCell3") { Class = "c" };
            new LabelGridSaveState(cellHeader3, "GridSaveState");
            var rowContent = new LayoutRow(container, "Content");
            var cellContent1 = new LayoutCell(rowContent, "ContentCell1") { Class = "c" };
            var cellContent2 = new LayoutCell(rowContent, "ContentCell2") { Class = "c2" };
            new Grid(cellContent1, "Master", "Master");
            new Grid(cellContent2, "Detail", "Detail");
            var rowFooter = new LayoutRow(container, "Footer");
            var cellFooter1 = new LayoutCell(rowFooter, "FooterCell1") { Class = "c" };
            var literal = new Literal(cellFooter1, "Literal");
            literal.Html = "Hello <b>Literal</b>";
            literal.Class = "y";
            var cellFooter2 = new LayoutCell(rowFooter, "FooterCell1") { Class = "c" };
            var button = new Button(cellFooter2, "Hello");
            //
            var gridDataJson = new GridDataJson();
            applicationJson.GridDataJson = gridDataJson;
            GridDataServer gridDataServer = new GridDataServer();
            gridDataServer.LoadDatabase("Master", typeof(Database.dbo.TableName));
            gridDataServer.SaveJson(applicationJson);
        }

        protected override void ProcessInit()
        {
            base.ProcessInit();
            ProcessListInsertAfter<ProcessGridIsIsClick>(new ProcessGridRowFirstIsClick(this));
            ProcessListInsertAfter<ProcessGridIsIsClick>(new ProcessGridMasterIsClick(this));
        }
    }

    public class ProcessGridMasterIsClick : ProcessBase
    {
        public ProcessGridMasterIsClick(ApplicationServerBase applicationServer) :
            base(applicationServer)
        {

        }

        protected override void ProcessEnd(ApplicationJson applicationJson)
        {
            foreach (GridRow gridRow in applicationJson.GridDataJson.RowList["Master"])
            {
                if (gridRow.IsClick)
                {
                    GridDataServer gridDataServer = new GridDataServer();
                    gridDataServer.LoadJson(applicationJson, "Master", typeof(ApplicationServer));
                    var row = gridDataServer.RowGet("Master", gridRow.Index).Row as Database.dbo.TableName;
                    string tableName = row.TableName2;
                    tableName = tableName.Substring(tableName.IndexOf(".") + 1);
                    //
                    Type typeRow = Framework.Server.DataAccessLayer.Util.TypeRowFromTableName(tableName, typeof(ApplicationServer));
                    gridDataServer = new GridDataServer();
                    gridDataServer.LoadDatabase("Detail", typeRow);
                    gridDataServer.SaveJson(applicationJson);
                }
            }
        }
    }
}

// Do not modify this file. It's generated by Framework.Cli.

namespace DatabaseBuiltIn.Demo
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.Linq;
    using Framework.DataAccessLayer;
    using Database.Demo;

    public static class LanguageBuiltInTableApplication
    {
        public enum IdNameEnum { [IdNameEnum(null)]None = 0, [IdNameEnum("English")]English = 1, [IdNameEnum("French")]French = 2, [IdNameEnum("German")]German = 3, [IdNameEnum("Italian")]Italian = 4 }

        public static LanguageBuiltIn Row(IdNameEnum value)
        {
            return RowList.Where(item => item.IdName == IdNameEnumAttribute.IdNameFromEnum(value)).SingleOrDefault();
        }

        public static IdNameEnum IdName(string idName)
        {
            return IdNameEnumAttribute.IdNameToEnum<IdNameEnum>(idName);
        }

        public static List<LanguageBuiltIn> RowList
        {
            get
            {
                var result = new List<LanguageBuiltIn>();
                result.Add(new LanguageBuiltIn() { Id = 1, IdName = "English", Name = "English", TextHtml = "<span class=\"flag-icon flag-icon-gb\"></span> English" });
                result.Add(new LanguageBuiltIn() { Id = 2, IdName = "French", Name = "French", TextHtml = "<span class=\"flag-icon flag-icon-fr\"></span> French" });
                result.Add(new LanguageBuiltIn() { Id = 3, IdName = "German", Name = "German", TextHtml = "<span class=\"flag-icon flag-icon-de\"></span> German" });
                result.Add(new LanguageBuiltIn() { Id = 4, IdName = "Italian", Name = "Italian", TextHtml = "<span class=\"flag-icon flag-icon-it\"></span> Italian" });
                return result;
            }
        }
    }

    public static class LoginPermissionBuiltInTableApplication
    {
        public enum IdNameEnum { [IdNameEnum(null)]None = 0, [IdNameEnum("Administrator")]Administrator = 1, [IdNameEnum("Developer")]Developer = 2, [IdNameEnum("Guest")]Guest = 3 }

        public static LoginPermissionBuiltIn Row(IdNameEnum value)
        {
            return RowList.Where(item => item.IdName == IdNameEnumAttribute.IdNameFromEnum(value)).SingleOrDefault();
        }

        public static IdNameEnum IdName(string idName)
        {
            return IdNameEnumAttribute.IdNameToEnum<IdNameEnum>(idName);
        }

        public static List<LoginPermissionBuiltIn> RowList
        {
            get
            {
                var result = new List<LoginPermissionBuiltIn>();
                result.Add(new LoginPermissionBuiltIn() { Id = 1, IdName = "Administrator", Name = "Administrator", Description = "Administrator permission", IsBuiltIn = true, IsExist = true });
                result.Add(new LoginPermissionBuiltIn() { Id = 2, IdName = "Developer", Name = "Developer", Description = "Developer permission", IsBuiltIn = true, IsExist = true });
                result.Add(new LoginPermissionBuiltIn() { Id = 3, IdName = "Guest", Name = "Guest", Description = "Guest permission", IsBuiltIn = true, IsExist = true });
                return result;
            }
        }
    }

    public static class RoadmapCategoryBuiltInTableApplication
    {
        public enum IdNameEnum { [IdNameEnum(null)]None = 0, [IdNameEnum("Analyze")]Analyze = 1, [IdNameEnum("Bug")]Bug = 2, [IdNameEnum("Feature")]Feature = 3 }

        public static RoadmapCategoryBuiltIn Row(IdNameEnum value)
        {
            return RowList.Where(item => item.IdName == IdNameEnumAttribute.IdNameFromEnum(value)).SingleOrDefault();
        }

        public static IdNameEnum IdName(string idName)
        {
            return IdNameEnumAttribute.IdNameToEnum<IdNameEnum>(idName);
        }

        public static List<RoadmapCategoryBuiltIn> RowList
        {
            get
            {
                var result = new List<RoadmapCategoryBuiltIn>();
                result.Add(new RoadmapCategoryBuiltIn() { Id = 1, IdName = "Analyze", Name = "Analyze", Text = "Analyze", Description = "Analyze", IsBuiltIn = true, IsExist = true });
                result.Add(new RoadmapCategoryBuiltIn() { Id = 2, IdName = "Bug", Name = "Bug", Text = "Bug", Description = "Software Bug", IsBuiltIn = true, IsExist = true });
                result.Add(new RoadmapCategoryBuiltIn() { Id = 3, IdName = "Feature", Name = "Feature", Text = "Feature", Description = "Software Feature", IsBuiltIn = true, IsExist = true });
                return result;
            }
        }
    }

    public static class RoadmapModuleBuiltInTableApplication
    {
        public enum IdNameEnum { [IdNameEnum(null)]None = 0, [IdNameEnum("Application")]Application = 1, [IdNameEnum("ApplicationCms")]ApplicationCms = 2, [IdNameEnum("ApplicationLogin")]ApplicationLogin = 3, [IdNameEnum("ApplicationRoadmap")]ApplicationRoadmap = 4, [IdNameEnum("Framework")]Framework = 5 }

        public static RoadmapModuleBuiltIn Row(IdNameEnum value)
        {
            return RowList.Where(item => item.IdName == IdNameEnumAttribute.IdNameFromEnum(value)).SingleOrDefault();
        }

        public static IdNameEnum IdName(string idName)
        {
            return IdNameEnumAttribute.IdNameToEnum<IdNameEnum>(idName);
        }

        public static List<RoadmapModuleBuiltIn> RowList
        {
            get
            {
                var result = new List<RoadmapModuleBuiltIn>();
                result.Add(new RoadmapModuleBuiltIn() { Id = 1, IdName = "Application", Name = "Application", Text = "Application", Description = null, IsBuiltIn = true, IsExist = true });
                result.Add(new RoadmapModuleBuiltIn() { Id = 2, IdName = "ApplicationCms", Name = "ApplicationCms", Text = "Application / Cms", Description = null, IsBuiltIn = true, IsExist = true });
                result.Add(new RoadmapModuleBuiltIn() { Id = 3, IdName = "ApplicationLogin", Name = "ApplicationLogin", Text = "Application / Login", Description = null, IsBuiltIn = true, IsExist = true });
                result.Add(new RoadmapModuleBuiltIn() { Id = 4, IdName = "ApplicationRoadmap", Name = "ApplicationRoadmap", Text = "Application / Roadmap", Description = null, IsBuiltIn = true, IsExist = true });
                result.Add(new RoadmapModuleBuiltIn() { Id = 5, IdName = "Framework", Name = "Framework", Text = "Framework", Description = null, IsBuiltIn = true, IsExist = true });
                return result;
            }
        }
    }

    public static class RoadmapPriorityBuiltInTableApplication
    {
        public enum IdNameEnum { [IdNameEnum(null)]None = 0, [IdNameEnum("Critical")]Critical = 1, [IdNameEnum("High")]High = 2, [IdNameEnum("Low")]Low = 3, [IdNameEnum("Medium")]Medium = 4 }

        public static RoadmapPriorityBuiltIn Row(IdNameEnum value)
        {
            return RowList.Where(item => item.IdName == IdNameEnumAttribute.IdNameFromEnum(value)).SingleOrDefault();
        }

        public static IdNameEnum IdName(string idName)
        {
            return IdNameEnumAttribute.IdNameToEnum<IdNameEnum>(idName);
        }

        public static List<RoadmapPriorityBuiltIn> RowList
        {
            get
            {
                var result = new List<RoadmapPriorityBuiltIn>();
                result.Add(new RoadmapPriorityBuiltIn() { Id = 1, IdName = "Critical", Name = "Critical", Text = "Critical (Red)", Description = null, IsBuiltIn = true, IsExist = true });
                result.Add(new RoadmapPriorityBuiltIn() { Id = 2, IdName = "High", Name = "High", Text = "High (Orange)", Description = null, IsBuiltIn = true, IsExist = true });
                result.Add(new RoadmapPriorityBuiltIn() { Id = 3, IdName = "Low", Name = "Low", Text = "Low (Green)", Description = null, IsBuiltIn = true, IsExist = true });
                result.Add(new RoadmapPriorityBuiltIn() { Id = 4, IdName = "Medium", Name = "Medium", Text = "Medium (Blue)", Description = null, IsBuiltIn = true, IsExist = true });
                return result;
            }
        }
    }

    public static class RoadmapStateBuiltInTableApplication
    {
        public enum IdNameEnum { [IdNameEnum(null)]None = 0, [IdNameEnum("Done")]Done = 1, [IdNameEnum("In Progress")]InProgress = 2, [IdNameEnum("New")]New = 3, [IdNameEnum("Open")]Open = 4 }

        public static RoadmapStateBuiltIn Row(IdNameEnum value)
        {
            return RowList.Where(item => item.IdName == IdNameEnumAttribute.IdNameFromEnum(value)).SingleOrDefault();
        }

        public static IdNameEnum IdName(string idName)
        {
            return IdNameEnumAttribute.IdNameToEnum<IdNameEnum>(idName);
        }

        public static List<RoadmapStateBuiltIn> RowList
        {
            get
            {
                var result = new List<RoadmapStateBuiltIn>();
                result.Add(new RoadmapStateBuiltIn() { Id = 1, IdName = "Done", Name = "Done", Text = "Done", Description = null, IsBuiltIn = true, IsExist = true });
                result.Add(new RoadmapStateBuiltIn() { Id = 2, IdName = "In Progress", Name = "In Progress", Text = "In Progress", Description = null, IsBuiltIn = true, IsExist = true });
                result.Add(new RoadmapStateBuiltIn() { Id = 3, IdName = "New", Name = "New", Text = "New", Description = null, IsBuiltIn = true, IsExist = true });
                result.Add(new RoadmapStateBuiltIn() { Id = 4, IdName = "Open", Name = "Open", Text = "Open", Description = null, IsBuiltIn = true, IsExist = true });
                return result;
            }
        }
    }

    public static class CmsComponentTypeBuiltInTableApplication
    {
        public enum IdNameEnum { [IdNameEnum(null)]None = 0, [IdNameEnum("Page")]Page = 1, [IdNameEnum("Paragraph")]Paragraph = 2, [IdNameEnum("Bullet")]Bullet = 3, [IdNameEnum("Image")]Image = 4, [IdNameEnum("Youtube")]Youtube = 5, [IdNameEnum("CodeBlock")]CodeBlock = 6, [IdNameEnum("Glossary")]Glossary = 7 }

        public static CmsComponentTypeBuiltIn Row(IdNameEnum value)
        {
            return RowList.Where(item => item.IdName == IdNameEnumAttribute.IdNameFromEnum(value)).SingleOrDefault();
        }

        public static IdNameEnum IdName(string idName)
        {
            return IdNameEnumAttribute.IdNameToEnum<IdNameEnum>(idName);
        }

        public static List<CmsComponentTypeBuiltIn> RowList
        {
            get
            {
                var result = new List<CmsComponentTypeBuiltIn>();
                result.Add(new CmsComponentTypeBuiltIn() { Id = 1, Name = "Page", Sort = 1, IdName = "Page" });
                result.Add(new CmsComponentTypeBuiltIn() { Id = 2, Name = "Paragraph", Sort = 2, IdName = "Paragraph" });
                result.Add(new CmsComponentTypeBuiltIn() { Id = 3, Name = "Bullet", Sort = 3, IdName = "Bullet" });
                result.Add(new CmsComponentTypeBuiltIn() { Id = 4, Name = "Image", Sort = 4, IdName = "Image" });
                result.Add(new CmsComponentTypeBuiltIn() { Id = 5, Name = "Youtube", Sort = 5, IdName = "Youtube" });
                result.Add(new CmsComponentTypeBuiltIn() { Id = 6, Name = "CodeBlock", Sort = 6, IdName = "CodeBlock" });
                result.Add(new CmsComponentTypeBuiltIn() { Id = 7, Name = "Glossary", Sort = 7, IdName = "Glossary" });
                return result;
            }
        }
    }
}

﻿using Abp.Authorization;
using Abp.Localization;
using Abp.MultiTenancy;

namespace LastProject.Authorization
{
    public class LastProjectAuthorizationProvider : AuthorizationProvider
    {
        public override void SetPermissions(IPermissionDefinitionContext context)
        {
            context.CreatePermission(PermissionNames.Pages_Home, L("Home"));
            context.CreatePermission(PermissionNames.Pages_Office, L("Office"));
            context.CreatePermission(PermissionNames.Pages_Department, L("Department"));
            context.CreatePermission(PermissionNames.Pages_GetMoney, L("GetMoney"));
            context.CreatePermission(PermissionNames.Pages_Instructor, L("Instructor"));
            context.CreatePermission(PermissionNames.Pages_Student, L("Student"));
            context.CreatePermission(PermissionNames.Pages_OfficeInstructor, L("OfficeInstructor"));
            context.CreatePermission(PermissionNames.Pages_DepartmentInstructor, L("DepartmentInstructor"));
            context.CreatePermission(PermissionNames.Pages_DepartmentCourse, L("DepartmentCourse"));
            context.CreatePermission(PermissionNames.Pages_InstructorCourse, L("InstructorCourse"));
            context.CreatePermission(PermissionNames.Pages_StudentCourse, L("StudentCourse"));
            context.CreatePermission(PermissionNames.Pages_OfficeReport, L("OfficeReport"));
            context.CreatePermission(PermissionNames.Pages_DepartmentReport, L("DepartmentReport"));
            context.CreatePermission(PermissionNames.Pages_CourseReport, L("CourseReport"));
            context.CreatePermission(PermissionNames.Pages_InstructorReport, L("InstructorReport"));
            context.CreatePermission(PermissionNames.Pages_StudentReport, L("StudentReport"));
            context.CreatePermission(PermissionNames.Pages_Tenants, L("Tenants"), multiTenancySides: MultiTenancySides.Host);
            context.CreatePermission(PermissionNames.Pages_Users, L("Users"));
            context.CreatePermission(PermissionNames.Pages_Roles, L("Roles"));
        }

        private static ILocalizableString L(string name)
        {
            return new LocalizableString(name, LastProjectConsts.LocalizationSourceName);
        }
    }
}

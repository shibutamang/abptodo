using abptodo.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace abptodo.Permissions
{
    public class abptodoPermissionDefinitionProvider : PermissionDefinitionProvider
    {
        public override void Define(IPermissionDefinitionContext context)
        {
            var myGroup = context.AddGroup(abptodoPermissions.GroupName);
            var myGroup_bookstore = context.AddGroup(abptodoPermissions.GroupName_BookStore);

            var parent_bookstore = myGroup_bookstore.AddPermission("BookStore");
            parent_bookstore.AddChild("BookStore_Create");
            parent_bookstore.AddChild("BookStore_Edit");
            parent_bookstore.AddChild("BookStore_Delete");
            //Define your own permissions here. Example:
            //myGroup.AddPermission(abptodoPermissions.MyPermission1, L("Permission:MyPermission1"));
        }

        private static LocalizableString L(string name)
        {
            return LocalizableString.Create<abptodoResource>(name);
        }
    }
}

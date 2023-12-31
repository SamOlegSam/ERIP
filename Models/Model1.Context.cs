﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Erip.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class ERIPEntities : DbContext
    {
        public ERIPEntities()
            : base("name=ERIPEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<dtproperties> dtproperties { get; set; }
        public virtual DbSet<S_Client> S_Client { get; set; }
        public virtual DbSet<S_Device> S_Device { get; set; }
        public virtual DbSet<S_Usluga> S_Usluga { get; set; }
        public virtual DbSet<T_204> T_204 { get; set; }
        public virtual DbSet<T_From210> T_From210 { get; set; }
        public virtual DbSet<T_FromERIP> T_FromERIP { get; set; }
        public virtual DbSet<T_Payments> T_Payments { get; set; }
        public virtual DbSet<T_ToERIP> T_ToERIP { get; set; }
        public virtual DbSet<V_FULL> V_FULL { get; set; }
    
        public virtual int dt_addtosourcecontrol(string vchSourceSafeINI, string vchProjectName, string vchComment, string vchLoginName, string vchPassword)
        {
            var vchSourceSafeINIParameter = vchSourceSafeINI != null ?
                new ObjectParameter("vchSourceSafeINI", vchSourceSafeINI) :
                new ObjectParameter("vchSourceSafeINI", typeof(string));
    
            var vchProjectNameParameter = vchProjectName != null ?
                new ObjectParameter("vchProjectName", vchProjectName) :
                new ObjectParameter("vchProjectName", typeof(string));
    
            var vchCommentParameter = vchComment != null ?
                new ObjectParameter("vchComment", vchComment) :
                new ObjectParameter("vchComment", typeof(string));
    
            var vchLoginNameParameter = vchLoginName != null ?
                new ObjectParameter("vchLoginName", vchLoginName) :
                new ObjectParameter("vchLoginName", typeof(string));
    
            var vchPasswordParameter = vchPassword != null ?
                new ObjectParameter("vchPassword", vchPassword) :
                new ObjectParameter("vchPassword", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("dt_addtosourcecontrol", vchSourceSafeINIParameter, vchProjectNameParameter, vchCommentParameter, vchLoginNameParameter, vchPasswordParameter);
        }
    
        public virtual int dt_addtosourcecontrol_u(string vchSourceSafeINI, string vchProjectName, string vchComment, string vchLoginName, string vchPassword)
        {
            var vchSourceSafeINIParameter = vchSourceSafeINI != null ?
                new ObjectParameter("vchSourceSafeINI", vchSourceSafeINI) :
                new ObjectParameter("vchSourceSafeINI", typeof(string));
    
            var vchProjectNameParameter = vchProjectName != null ?
                new ObjectParameter("vchProjectName", vchProjectName) :
                new ObjectParameter("vchProjectName", typeof(string));
    
            var vchCommentParameter = vchComment != null ?
                new ObjectParameter("vchComment", vchComment) :
                new ObjectParameter("vchComment", typeof(string));
    
            var vchLoginNameParameter = vchLoginName != null ?
                new ObjectParameter("vchLoginName", vchLoginName) :
                new ObjectParameter("vchLoginName", typeof(string));
    
            var vchPasswordParameter = vchPassword != null ?
                new ObjectParameter("vchPassword", vchPassword) :
                new ObjectParameter("vchPassword", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("dt_addtosourcecontrol_u", vchSourceSafeINIParameter, vchProjectNameParameter, vchCommentParameter, vchLoginNameParameter, vchPasswordParameter);
        }
    
        public virtual int dt_adduserobject()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("dt_adduserobject");
        }
    
        public virtual int dt_adduserobject_vcs(string vchProperty)
        {
            var vchPropertyParameter = vchProperty != null ?
                new ObjectParameter("vchProperty", vchProperty) :
                new ObjectParameter("vchProperty", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("dt_adduserobject_vcs", vchPropertyParameter);
        }
    
        public virtual int dt_checkinobject(string chObjectType, string vchObjectName, string vchComment, string vchLoginName, string vchPassword, Nullable<int> iVCSFlags, Nullable<int> iActionFlag, string txStream1, string txStream2, string txStream3)
        {
            var chObjectTypeParameter = chObjectType != null ?
                new ObjectParameter("chObjectType", chObjectType) :
                new ObjectParameter("chObjectType", typeof(string));
    
            var vchObjectNameParameter = vchObjectName != null ?
                new ObjectParameter("vchObjectName", vchObjectName) :
                new ObjectParameter("vchObjectName", typeof(string));
    
            var vchCommentParameter = vchComment != null ?
                new ObjectParameter("vchComment", vchComment) :
                new ObjectParameter("vchComment", typeof(string));
    
            var vchLoginNameParameter = vchLoginName != null ?
                new ObjectParameter("vchLoginName", vchLoginName) :
                new ObjectParameter("vchLoginName", typeof(string));
    
            var vchPasswordParameter = vchPassword != null ?
                new ObjectParameter("vchPassword", vchPassword) :
                new ObjectParameter("vchPassword", typeof(string));
    
            var iVCSFlagsParameter = iVCSFlags.HasValue ?
                new ObjectParameter("iVCSFlags", iVCSFlags) :
                new ObjectParameter("iVCSFlags", typeof(int));
    
            var iActionFlagParameter = iActionFlag.HasValue ?
                new ObjectParameter("iActionFlag", iActionFlag) :
                new ObjectParameter("iActionFlag", typeof(int));
    
            var txStream1Parameter = txStream1 != null ?
                new ObjectParameter("txStream1", txStream1) :
                new ObjectParameter("txStream1", typeof(string));
    
            var txStream2Parameter = txStream2 != null ?
                new ObjectParameter("txStream2", txStream2) :
                new ObjectParameter("txStream2", typeof(string));
    
            var txStream3Parameter = txStream3 != null ?
                new ObjectParameter("txStream3", txStream3) :
                new ObjectParameter("txStream3", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("dt_checkinobject", chObjectTypeParameter, vchObjectNameParameter, vchCommentParameter, vchLoginNameParameter, vchPasswordParameter, iVCSFlagsParameter, iActionFlagParameter, txStream1Parameter, txStream2Parameter, txStream3Parameter);
        }
    
        public virtual int dt_checkinobject_u(string chObjectType, string vchObjectName, string vchComment, string vchLoginName, string vchPassword, Nullable<int> iVCSFlags, Nullable<int> iActionFlag, string txStream1, string txStream2, string txStream3)
        {
            var chObjectTypeParameter = chObjectType != null ?
                new ObjectParameter("chObjectType", chObjectType) :
                new ObjectParameter("chObjectType", typeof(string));
    
            var vchObjectNameParameter = vchObjectName != null ?
                new ObjectParameter("vchObjectName", vchObjectName) :
                new ObjectParameter("vchObjectName", typeof(string));
    
            var vchCommentParameter = vchComment != null ?
                new ObjectParameter("vchComment", vchComment) :
                new ObjectParameter("vchComment", typeof(string));
    
            var vchLoginNameParameter = vchLoginName != null ?
                new ObjectParameter("vchLoginName", vchLoginName) :
                new ObjectParameter("vchLoginName", typeof(string));
    
            var vchPasswordParameter = vchPassword != null ?
                new ObjectParameter("vchPassword", vchPassword) :
                new ObjectParameter("vchPassword", typeof(string));
    
            var iVCSFlagsParameter = iVCSFlags.HasValue ?
                new ObjectParameter("iVCSFlags", iVCSFlags) :
                new ObjectParameter("iVCSFlags", typeof(int));
    
            var iActionFlagParameter = iActionFlag.HasValue ?
                new ObjectParameter("iActionFlag", iActionFlag) :
                new ObjectParameter("iActionFlag", typeof(int));
    
            var txStream1Parameter = txStream1 != null ?
                new ObjectParameter("txStream1", txStream1) :
                new ObjectParameter("txStream1", typeof(string));
    
            var txStream2Parameter = txStream2 != null ?
                new ObjectParameter("txStream2", txStream2) :
                new ObjectParameter("txStream2", typeof(string));
    
            var txStream3Parameter = txStream3 != null ?
                new ObjectParameter("txStream3", txStream3) :
                new ObjectParameter("txStream3", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("dt_checkinobject_u", chObjectTypeParameter, vchObjectNameParameter, vchCommentParameter, vchLoginNameParameter, vchPasswordParameter, iVCSFlagsParameter, iActionFlagParameter, txStream1Parameter, txStream2Parameter, txStream3Parameter);
        }
    
        public virtual int dt_checkoutobject(string chObjectType, string vchObjectName, string vchComment, string vchLoginName, string vchPassword, Nullable<int> iVCSFlags, Nullable<int> iActionFlag)
        {
            var chObjectTypeParameter = chObjectType != null ?
                new ObjectParameter("chObjectType", chObjectType) :
                new ObjectParameter("chObjectType", typeof(string));
    
            var vchObjectNameParameter = vchObjectName != null ?
                new ObjectParameter("vchObjectName", vchObjectName) :
                new ObjectParameter("vchObjectName", typeof(string));
    
            var vchCommentParameter = vchComment != null ?
                new ObjectParameter("vchComment", vchComment) :
                new ObjectParameter("vchComment", typeof(string));
    
            var vchLoginNameParameter = vchLoginName != null ?
                new ObjectParameter("vchLoginName", vchLoginName) :
                new ObjectParameter("vchLoginName", typeof(string));
    
            var vchPasswordParameter = vchPassword != null ?
                new ObjectParameter("vchPassword", vchPassword) :
                new ObjectParameter("vchPassword", typeof(string));
    
            var iVCSFlagsParameter = iVCSFlags.HasValue ?
                new ObjectParameter("iVCSFlags", iVCSFlags) :
                new ObjectParameter("iVCSFlags", typeof(int));
    
            var iActionFlagParameter = iActionFlag.HasValue ?
                new ObjectParameter("iActionFlag", iActionFlag) :
                new ObjectParameter("iActionFlag", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("dt_checkoutobject", chObjectTypeParameter, vchObjectNameParameter, vchCommentParameter, vchLoginNameParameter, vchPasswordParameter, iVCSFlagsParameter, iActionFlagParameter);
        }
    
        public virtual int dt_checkoutobject_u(string chObjectType, string vchObjectName, string vchComment, string vchLoginName, string vchPassword, Nullable<int> iVCSFlags, Nullable<int> iActionFlag)
        {
            var chObjectTypeParameter = chObjectType != null ?
                new ObjectParameter("chObjectType", chObjectType) :
                new ObjectParameter("chObjectType", typeof(string));
    
            var vchObjectNameParameter = vchObjectName != null ?
                new ObjectParameter("vchObjectName", vchObjectName) :
                new ObjectParameter("vchObjectName", typeof(string));
    
            var vchCommentParameter = vchComment != null ?
                new ObjectParameter("vchComment", vchComment) :
                new ObjectParameter("vchComment", typeof(string));
    
            var vchLoginNameParameter = vchLoginName != null ?
                new ObjectParameter("vchLoginName", vchLoginName) :
                new ObjectParameter("vchLoginName", typeof(string));
    
            var vchPasswordParameter = vchPassword != null ?
                new ObjectParameter("vchPassword", vchPassword) :
                new ObjectParameter("vchPassword", typeof(string));
    
            var iVCSFlagsParameter = iVCSFlags.HasValue ?
                new ObjectParameter("iVCSFlags", iVCSFlags) :
                new ObjectParameter("iVCSFlags", typeof(int));
    
            var iActionFlagParameter = iActionFlag.HasValue ?
                new ObjectParameter("iActionFlag", iActionFlag) :
                new ObjectParameter("iActionFlag", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("dt_checkoutobject_u", chObjectTypeParameter, vchObjectNameParameter, vchCommentParameter, vchLoginNameParameter, vchPasswordParameter, iVCSFlagsParameter, iActionFlagParameter);
        }
    
        public virtual int dt_displayoaerror(Nullable<int> iObject, Nullable<int> iresult)
        {
            var iObjectParameter = iObject.HasValue ?
                new ObjectParameter("iObject", iObject) :
                new ObjectParameter("iObject", typeof(int));
    
            var iresultParameter = iresult.HasValue ?
                new ObjectParameter("iresult", iresult) :
                new ObjectParameter("iresult", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("dt_displayoaerror", iObjectParameter, iresultParameter);
        }
    
        public virtual int dt_displayoaerror_u(Nullable<int> iObject, Nullable<int> iresult)
        {
            var iObjectParameter = iObject.HasValue ?
                new ObjectParameter("iObject", iObject) :
                new ObjectParameter("iObject", typeof(int));
    
            var iresultParameter = iresult.HasValue ?
                new ObjectParameter("iresult", iresult) :
                new ObjectParameter("iresult", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("dt_displayoaerror_u", iObjectParameter, iresultParameter);
        }
    
        public virtual int dt_droppropertiesbyid(Nullable<int> id, string property)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(int));
    
            var propertyParameter = property != null ?
                new ObjectParameter("property", property) :
                new ObjectParameter("property", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("dt_droppropertiesbyid", idParameter, propertyParameter);
        }
    
        public virtual int dt_dropuserobjectbyid(Nullable<int> id)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("dt_dropuserobjectbyid", idParameter);
        }
    
        public virtual int dt_generateansiname(ObjectParameter name)
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("dt_generateansiname", name);
        }
    
        public virtual ObjectResult<Nullable<int>> dt_getobjwithprop(string property, string value)
        {
            var propertyParameter = property != null ?
                new ObjectParameter("property", property) :
                new ObjectParameter("property", typeof(string));
    
            var valueParameter = value != null ?
                new ObjectParameter("value", value) :
                new ObjectParameter("value", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<int>>("dt_getobjwithprop", propertyParameter, valueParameter);
        }
    
        public virtual ObjectResult<Nullable<int>> dt_getobjwithprop_u(string property, string uvalue)
        {
            var propertyParameter = property != null ?
                new ObjectParameter("property", property) :
                new ObjectParameter("property", typeof(string));
    
            var uvalueParameter = uvalue != null ?
                new ObjectParameter("uvalue", uvalue) :
                new ObjectParameter("uvalue", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<int>>("dt_getobjwithprop_u", propertyParameter, uvalueParameter);
        }
    
        public virtual ObjectResult<dt_getpropertiesbyid_Result> dt_getpropertiesbyid(Nullable<int> id, string property)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(int));
    
            var propertyParameter = property != null ?
                new ObjectParameter("property", property) :
                new ObjectParameter("property", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<dt_getpropertiesbyid_Result>("dt_getpropertiesbyid", idParameter, propertyParameter);
        }
    
        public virtual ObjectResult<dt_getpropertiesbyid_u_Result> dt_getpropertiesbyid_u(Nullable<int> id, string property)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(int));
    
            var propertyParameter = property != null ?
                new ObjectParameter("property", property) :
                new ObjectParameter("property", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<dt_getpropertiesbyid_u_Result>("dt_getpropertiesbyid_u", idParameter, propertyParameter);
        }
    
        public virtual int dt_getpropertiesbyid_vcs(Nullable<int> id, string property, ObjectParameter value)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(int));
    
            var propertyParameter = property != null ?
                new ObjectParameter("property", property) :
                new ObjectParameter("property", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("dt_getpropertiesbyid_vcs", idParameter, propertyParameter, value);
        }
    
        public virtual int dt_getpropertiesbyid_vcs_u(Nullable<int> id, string property, ObjectParameter value)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(int));
    
            var propertyParameter = property != null ?
                new ObjectParameter("property", property) :
                new ObjectParameter("property", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("dt_getpropertiesbyid_vcs_u", idParameter, propertyParameter, value);
        }
    
        public virtual int dt_isundersourcecontrol(string vchLoginName, string vchPassword, Nullable<int> iWhoToo)
        {
            var vchLoginNameParameter = vchLoginName != null ?
                new ObjectParameter("vchLoginName", vchLoginName) :
                new ObjectParameter("vchLoginName", typeof(string));
    
            var vchPasswordParameter = vchPassword != null ?
                new ObjectParameter("vchPassword", vchPassword) :
                new ObjectParameter("vchPassword", typeof(string));
    
            var iWhoTooParameter = iWhoToo.HasValue ?
                new ObjectParameter("iWhoToo", iWhoToo) :
                new ObjectParameter("iWhoToo", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("dt_isundersourcecontrol", vchLoginNameParameter, vchPasswordParameter, iWhoTooParameter);
        }
    
        public virtual int dt_isundersourcecontrol_u(string vchLoginName, string vchPassword, Nullable<int> iWhoToo)
        {
            var vchLoginNameParameter = vchLoginName != null ?
                new ObjectParameter("vchLoginName", vchLoginName) :
                new ObjectParameter("vchLoginName", typeof(string));
    
            var vchPasswordParameter = vchPassword != null ?
                new ObjectParameter("vchPassword", vchPassword) :
                new ObjectParameter("vchPassword", typeof(string));
    
            var iWhoTooParameter = iWhoToo.HasValue ?
                new ObjectParameter("iWhoToo", iWhoToo) :
                new ObjectParameter("iWhoToo", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("dt_isundersourcecontrol_u", vchLoginNameParameter, vchPasswordParameter, iWhoTooParameter);
        }
    
        public virtual int dt_removefromsourcecontrol()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("dt_removefromsourcecontrol");
        }
    
        public virtual int dt_setpropertybyid(Nullable<int> id, string property, string value, byte[] lvalue)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(int));
    
            var propertyParameter = property != null ?
                new ObjectParameter("property", property) :
                new ObjectParameter("property", typeof(string));
    
            var valueParameter = value != null ?
                new ObjectParameter("value", value) :
                new ObjectParameter("value", typeof(string));
    
            var lvalueParameter = lvalue != null ?
                new ObjectParameter("lvalue", lvalue) :
                new ObjectParameter("lvalue", typeof(byte[]));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("dt_setpropertybyid", idParameter, propertyParameter, valueParameter, lvalueParameter);
        }
    
        public virtual int dt_setpropertybyid_u(Nullable<int> id, string property, string uvalue, byte[] lvalue)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(int));
    
            var propertyParameter = property != null ?
                new ObjectParameter("property", property) :
                new ObjectParameter("property", typeof(string));
    
            var uvalueParameter = uvalue != null ?
                new ObjectParameter("uvalue", uvalue) :
                new ObjectParameter("uvalue", typeof(string));
    
            var lvalueParameter = lvalue != null ?
                new ObjectParameter("lvalue", lvalue) :
                new ObjectParameter("lvalue", typeof(byte[]));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("dt_setpropertybyid_u", idParameter, propertyParameter, uvalueParameter, lvalueParameter);
        }
    
        public virtual int dt_validateloginparams(string vchLoginName, string vchPassword)
        {
            var vchLoginNameParameter = vchLoginName != null ?
                new ObjectParameter("vchLoginName", vchLoginName) :
                new ObjectParameter("vchLoginName", typeof(string));
    
            var vchPasswordParameter = vchPassword != null ?
                new ObjectParameter("vchPassword", vchPassword) :
                new ObjectParameter("vchPassword", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("dt_validateloginparams", vchLoginNameParameter, vchPasswordParameter);
        }
    
        public virtual int dt_validateloginparams_u(string vchLoginName, string vchPassword)
        {
            var vchLoginNameParameter = vchLoginName != null ?
                new ObjectParameter("vchLoginName", vchLoginName) :
                new ObjectParameter("vchLoginName", typeof(string));
    
            var vchPasswordParameter = vchPassword != null ?
                new ObjectParameter("vchPassword", vchPassword) :
                new ObjectParameter("vchPassword", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("dt_validateloginparams_u", vchLoginNameParameter, vchPasswordParameter);
        }
    
        public virtual int dt_vcsenabled()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("dt_vcsenabled");
        }
    
        public virtual ObjectResult<Nullable<int>> dt_verstamp006()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<int>>("dt_verstamp006");
        }
    
        public virtual int dt_whocheckedout(string chObjectType, string vchObjectName, string vchLoginName, string vchPassword)
        {
            var chObjectTypeParameter = chObjectType != null ?
                new ObjectParameter("chObjectType", chObjectType) :
                new ObjectParameter("chObjectType", typeof(string));
    
            var vchObjectNameParameter = vchObjectName != null ?
                new ObjectParameter("vchObjectName", vchObjectName) :
                new ObjectParameter("vchObjectName", typeof(string));
    
            var vchLoginNameParameter = vchLoginName != null ?
                new ObjectParameter("vchLoginName", vchLoginName) :
                new ObjectParameter("vchLoginName", typeof(string));
    
            var vchPasswordParameter = vchPassword != null ?
                new ObjectParameter("vchPassword", vchPassword) :
                new ObjectParameter("vchPassword", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("dt_whocheckedout", chObjectTypeParameter, vchObjectNameParameter, vchLoginNameParameter, vchPasswordParameter);
        }
    
        public virtual int dt_whocheckedout_u(string chObjectType, string vchObjectName, string vchLoginName, string vchPassword)
        {
            var chObjectTypeParameter = chObjectType != null ?
                new ObjectParameter("chObjectType", chObjectType) :
                new ObjectParameter("chObjectType", typeof(string));
    
            var vchObjectNameParameter = vchObjectName != null ?
                new ObjectParameter("vchObjectName", vchObjectName) :
                new ObjectParameter("vchObjectName", typeof(string));
    
            var vchLoginNameParameter = vchLoginName != null ?
                new ObjectParameter("vchLoginName", vchLoginName) :
                new ObjectParameter("vchLoginName", typeof(string));
    
            var vchPasswordParameter = vchPassword != null ?
                new ObjectParameter("vchPassword", vchPassword) :
                new ObjectParameter("vchPassword", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("dt_whocheckedout_u", chObjectTypeParameter, vchObjectNameParameter, vchLoginNameParameter, vchPasswordParameter);
        }
    }
}

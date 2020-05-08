#pragma warning disable
#line 1 "modConnection.cs"
#pragma warning disable
#line 1 "modConnection.cs"
using System;
using System.Data.Common;
using UpgradeHelpers.DB.ADO;
using Mobilize.WebMap.Common.Attributes;

namespace SKS
{

   [Observable]
   internal static class modConnection
   {

      [Intercepted]


      private static DbConnection _CurrentConnection 
#line 16
                                                     { 
#line 16
                                                       get                                                          
#line hidden
{var catalog = _Mobilize_AssemblySharedStateCatalog.GetCached();return (System.Data.Common.DbConnection)catalog.modConnection._CurrentConnection;} 
#line 16

#line 16
                                                            set                                                               
#line hidden
{var catalog = _Mobilize_AssemblySharedStateCatalog.GetCached();catalog.modConnection._CurrentConnection = value;} 
#line 16
                                                                 } 
#line 17

      [Intercepted]
      internal static DbConnection CurrentConnection
      {
      	get
      	{
      		if (_CurrentConnection == null)
            {
            	_CurrentConnection = UpgradeHelpers.DB.AdoFactoryManager.GetFactory().CreateConnection();
            }
            return _CurrentConnection;
         }
         set
         {
            _CurrentConnection = value;
         }
      }

      [Intercepted]

      private static ADORecordSetHelper _rs 
#line 37
                                            { 
#line 37
                                              get                                                 
#line hidden
{var catalog = _Mobilize_AssemblySharedStateCatalog.GetCached();return (UpgradeHelpers.DB.ADO.ADORecordSetHelper)catalog.modConnection._rs;} 
#line 37

#line 37
                                                   set                                                      
#line hidden
{var catalog = _Mobilize_AssemblySharedStateCatalog.GetCached();catalog.modConnection._rs = value;} 
#line 37
                                                        } 
#line 38

      [Intercepted]
      internal static ADORecordSetHelper rs
      {
      	get
      	{
      		if (_rs == null)
            {
            	_rs = new ADORecordSetHelper("");
            }
            return _rs;
         }
         set
         {
            _rs = value;
         }
      }

      [Intercepted]

      private static ADORecordSetHelper _rs2 
#line 58
                                             { 
#line 58
                                               get                                                  
#line hidden
{var catalog = _Mobilize_AssemblySharedStateCatalog.GetCached();return (UpgradeHelpers.DB.ADO.ADORecordSetHelper)catalog.modConnection._rs2;} 
#line 58

#line 58
                                                    set                                                       
#line hidden
{var catalog = _Mobilize_AssemblySharedStateCatalog.GetCached();catalog.modConnection._rs2 = value;} 
#line 58
                                                         } 
#line 59

      [Intercepted]
      internal static ADORecordSetHelper rs2
      {
      	get
      	{
      		if (_rs2 == null)
            {
            	_rs2 = new ADORecordSetHelper("");
            }
            return _rs2;
         }
         set
         {
            _rs2 = value;
         }
      }


      internal static void OpenConnection()
      {
      	CurrentConnection = UpgradeHelpers.DB.AdoFactoryManager.GetFactory().CreateConnection();
      	//UPGRADE_TODO: (7010) The connection string must be verified to fullfill the .NET data provider connection string requirements. More Information: https://www.mobilize.net/vbtonet/ewis/ewi7010
      	CurrentConnection.ConnectionString = modMain.ConnectionString;
      	CurrentConnection.Open();
      }

      internal static void ExecuteSql(string Statement)
      {
      	rs = new ADORecordSetHelper("");
      	rs.Open(Statement, CurrentConnection, UpgradeHelpers.DB.LockTypeEnum.LockPessimistic);
      }

      internal static void ExecuteSql2(string Statement)
      {
      	rs2 = new ADORecordSetHelper("");
      	rs2.Open(Statement, CurrentConnection, UpgradeHelpers.DB.LockTypeEnum.LockPessimistic);
      }
public class _Mobilize_SharedState :Mobilize.WebMap.Common.Core.IObservable,Mobilize.WebMap.Common.Core.IDelta{
#line hidden
private Mobilize.WebMap.Common.Core.Identifier[] _Mobilize_References=new Mobilize.WebMap.Common.Core.Identifier[3];
Mobilize.WebMap.Common.Core.Identifier Mobilize.WebMap.Common.Core.IObservable.MobilizeId{get ;set ;}=Mobilize.WebMap.Common.Core.Context.CoreContext.Services.IdentifierService.GetIdentifier();
Mobilize.WebMap.Common.Core.ReferenceMap Mobilize.WebMap.Common.Core.IObservable.References{
get=>this._Mobilize_GetReferenceMap(new Mobilize.WebMap.Common.Core.ReferenceMap());
set=>throw new System.NotImplementedException();}

protected uint _Mobilize_ControlFlag=1;
bool Mobilize.WebMap.Common.Core.ITrackable.IsNew {get =>(this._Mobilize_ControlFlag&_Mobilize_IsNew_Flag)>0;
set =>_Mobilize_ControlFlag=value?this._Mobilize_ControlFlag=1<<0:this._Mobilize_ControlFlag&0<<0;
}
Mobilize.WebMap.Common.Core.IDelta Mobilize.WebMap.Common.Core.ITrackable.Delta =>this;
void Mobilize.WebMap.Common.Core.ITrackable.CleanChanges ()=>_Mobilize_CleanChanges();
protected virtual void _Mobilize_CleanChanges ()
{if(!((Mobilize.WebMap.Common.Core.ITrackable)this).IsNew||((Mobilize.WebMap.Common.Core.IObservable)this).RefCount>0)
{this._Mobilize_DirtyFlag_0=0;
this._Mobilize_LoadedFlag_0=0;
this._Mobilize_ControlFlag=0;
}
}
protected virtual Mobilize.WebMap.Common.Core.ReferenceMap _Mobilize_GetReferenceMap(Mobilize.WebMap.Common.Core.ReferenceMap refs)
{refs["_CurrentConnection"]=_Mobilize_References[0];
refs["_rs"]=_Mobilize_References[1];
refs["_rs2"]=_Mobilize_References[2];
return refs;
}
private int _Mobilize_RefCount=0;
int Mobilize.WebMap.Common.Core.IObservable.DecrementRefCount ()
{return System.Threading.Interlocked.Decrement(ref _Mobilize_RefCount);
}
int Mobilize.WebMap.Common.Core.IObservable.IncrementRefCount ()
{return System.Threading.Interlocked.Increment(ref _Mobilize_RefCount);
}
int Mobilize.WebMap.Common.Core.IObservable.RefCount{get
{return _Mobilize_RefCount;
}
}
System.Collections.Generic.IEnumerable<Mobilize.WebMap.Common.Core.IObservable> Mobilize.WebMap.Common.Core.IObservable.GetReferences()
{return this._Mobilize_GetReferences();
}
protected virtual System.Collections.Generic.IEnumerable<Mobilize.WebMap.Common.Core.IObservable> _Mobilize_GetReferences(){var ref__CurrentConnection=Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetAsObservable(this._CurrentConnection);if(ref__CurrentConnection!=null)yield return ref__CurrentConnection;
var ref__rs=Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetAsObservable(this._rs);if(ref__rs!=null)yield return ref__rs;
var ref__rs2=Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetAsObservable(this._rs2);if(ref__rs2!=null)yield return ref__rs2;
yield break ;
}
const uint _Mobilize_IsNew_Flag=(uint)1<<0;
protected const uint _Mobilize_HasChanged_Flag=(uint)1<<1;
bool Mobilize.WebMap.Common.Core.ITrackable.HasChanged{get=>(this._Mobilize_ControlFlag&_Mobilize_HasChanged_Flag)>0;}
const uint _Mobilize_IsRefresh_Flag=(uint)1<<2;
bool Mobilize.WebMap.Common.Core.ITrackable.IsRefresh {get =>(this._Mobilize_ControlFlag&_Mobilize_IsRefresh_Flag)>0;
set =>_Mobilize_ControlFlag=value?this._Mobilize_ControlFlag=1<<2:this._Mobilize_ControlFlag&0<<2;
}
const uint _Mobilize_IsMarked_Flag=(uint)1<<3;
bool Mobilize.WebMap.Common.Core.ITrackable.IsMarked {get =>(this._Mobilize_ControlFlag&_Mobilize_IsMarked_Flag)>0;
set =>_Mobilize_ControlFlag=value?this._Mobilize_ControlFlag=1<<3:this._Mobilize_ControlFlag&0<<3;
}
bool Mobilize.WebMap.Common.Core.IDelta.IsNew{get =>(this._Mobilize_ControlFlag&_Mobilize_IsNew_Flag)>0;
set =>_Mobilize_ControlFlag=value?this._Mobilize_ControlFlag=1<<0:this._Mobilize_ControlFlag&0<<0;
}Mobilize.WebMap.Common.Core.IObservable Mobilize.WebMap.Common.Core.IDelta.Target{get =>this;
set =>throw new System.NotImplementedException();
}System.Collections.Generic.IEnumerable<string> Mobilize.WebMap.Common.Core.IDelta.Changes=>this._Mobilize_GetChanges();
bool Mobilize.WebMap.Common.Core.IDelta.HasChanges(string propertyName)=>this._Mobilize_HasChanges(propertyName);
protected virtual System.Collections.Generic.IEnumerable<string> _Mobilize_GetChanges()
{if((_Mobilize_DirtyFlag_0&_Mobilize_Dirty__CurrentConnection)>0)
{yield return "_CurrentConnection";
}
if((_Mobilize_DirtyFlag_0&_Mobilize_Dirty__rs)>0)
{yield return "_rs";
}
if((_Mobilize_DirtyFlag_0&_Mobilize_Dirty__rs2)>0)
{yield return "_rs2";
}
yield break ;
}
protected virtual bool _Mobilize_HasChanges(string propertyName)
{switch(propertyName){case "_CurrentConnection":return (_Mobilize_DirtyFlag_0&_Mobilize_Dirty__CurrentConnection)>0;
case "_rs":return (_Mobilize_DirtyFlag_0&_Mobilize_Dirty__rs)>0;
case "_rs2":return (_Mobilize_DirtyFlag_0&_Mobilize_Dirty__rs2)>0;
}return false;
}
private uint _Mobilize_DirtyFlag_0;
private uint _Mobilize_LoadedFlag_0;
const uint _Mobilize_Dirty__CurrentConnection=(uint)1<<0;
const uint _Mobilize_Loaded__CurrentConnection=(uint)1<<0;
const uint _Mobilize_Dirty__rs=(uint)1<<1;
const uint _Mobilize_Loaded__rs=(uint)1<<1;
const uint _Mobilize_Dirty__rs2=(uint)1<<2;
const uint _Mobilize_Loaded__rs2=(uint)1<<2;
private void Mobilize_Initialize_Properties()
{                                                                   this._CurrentConnection=null;
#line hidden
                                                           this._rs=null;
#line hidden
                                                            this._rs2=null;
#line hidden
 }
public _Mobilize_SharedState (){this.Mobilize_Initialize_Properties();
}
#line hidden
                                                                   
[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private System.Data.Common.DbConnection _CurrentConnection_k__BackingField;                                                                   
internal object _CurrentConnection {get
#line hidden
{if((_Mobilize_LoadedFlag_0&_Mobilize_Loaded__CurrentConnection)<=0){this._CurrentConnection_k__BackingField=Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetNonObservable<System.Data.Common.DbConnection>(this,_Mobilize_References,0);_Mobilize_LoadedFlag_0|=_Mobilize_Loaded__CurrentConnection;}return this._CurrentConnection_k__BackingField;}set
#line hidden
{if(Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.SetNonObservable<object >(this,_Mobilize_References,0,this._CurrentConnection_k__BackingField,(System.Data.Common.DbConnection)value)){_Mobilize_DirtyFlag_0|=_Mobilize_Dirty__CurrentConnection;}_Mobilize_LoadedFlag_0|=_Mobilize_Loaded__CurrentConnection;_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this._CurrentConnection_k__BackingField=(System.Data.Common.DbConnection)value;}}
#line hidden
                                                          
[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private UpgradeHelpers.DB.ADO.ADORecordSetHelper _rs_k__BackingField;                                                          
internal object _rs {get
#line hidden
{if((_Mobilize_LoadedFlag_0&_Mobilize_Loaded__rs)<=0){this._rs_k__BackingField=Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetNonObservable<UpgradeHelpers.DB.ADO.ADORecordSetHelper>(this,_Mobilize_References,1);_Mobilize_LoadedFlag_0|=_Mobilize_Loaded__rs;}return this._rs_k__BackingField;}set
#line hidden
{if(Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.SetNonObservable<object >(this,_Mobilize_References,1,this._rs_k__BackingField,(UpgradeHelpers.DB.ADO.ADORecordSetHelper)value)){_Mobilize_DirtyFlag_0|=_Mobilize_Dirty__rs;}_Mobilize_LoadedFlag_0|=_Mobilize_Loaded__rs;_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this._rs_k__BackingField=(UpgradeHelpers.DB.ADO.ADORecordSetHelper)value;}}
#line hidden
                                                           
[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private UpgradeHelpers.DB.ADO.ADORecordSetHelper _rs2_k__BackingField;                                                           
internal object _rs2 {get
#line hidden
{if((_Mobilize_LoadedFlag_0&_Mobilize_Loaded__rs2)<=0){this._rs2_k__BackingField=Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetNonObservable<UpgradeHelpers.DB.ADO.ADORecordSetHelper>(this,_Mobilize_References,2);_Mobilize_LoadedFlag_0|=_Mobilize_Loaded__rs2;}return this._rs2_k__BackingField;}set
#line hidden
{if(Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.SetNonObservable<object >(this,_Mobilize_References,2,this._rs2_k__BackingField,(UpgradeHelpers.DB.ADO.ADORecordSetHelper)value)){_Mobilize_DirtyFlag_0|=_Mobilize_Dirty__rs2;}_Mobilize_LoadedFlag_0|=_Mobilize_Loaded__rs2;_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this._rs2_k__BackingField=(UpgradeHelpers.DB.ADO.ADORecordSetHelper)value;}}}
   }
}
#pragma warning restore

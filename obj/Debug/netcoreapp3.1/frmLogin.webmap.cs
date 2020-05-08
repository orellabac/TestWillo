#pragma warning disable
#line 1 "frmLogin.cs"
#pragma warning disable
#line 1 "frmLogin.cs"
using System;
using UpgradeHelpers.DB.ADO;
using UpgradeHelpers.Helpers;
using Mobilize.WebMap.Common.Attributes;
using Mobilize.Web.Extensions;

namespace SKS
{

   [Observable]
   internal partial class frmLogin
      : Mobilize.Web.Form
   {
#line hidden
private Mobilize.WebMap.Common.Core.Identifier[] _Mobilize_References=new Mobilize.WebMap.Common.Core.Identifier[10];
protected override System.Collections.Generic.IEnumerable<string> _Mobilize_GetChanges()
{
foreach(var item in base._Mobilize_GetChanges())

{yield return item;}
if((_Mobilize_DirtyFlag_0&_Mobilize_Dirty_LoginSucceeded)>0)
{yield return "LoginSucceeded";
}
if((_Mobilize_DirtyFlag_0&_Mobilize_Dirty_visualControls)>0)
{yield return "visualControls";
}
if((_Mobilize_DirtyFlag_0&_Mobilize_Dirty_components)>0)
{yield return "components";
}
if((_Mobilize_DirtyFlag_0&_Mobilize_Dirty_ToolTipMain)>0)
{yield return "ToolTipMain";
}
if((_Mobilize_DirtyFlag_0&_Mobilize_Dirty_txtUserName)>0)
{yield return "txtUserName";
}
if((_Mobilize_DirtyFlag_0&_Mobilize_Dirty_cmdCancel)>0)
{yield return "cmdCancel";
}
if((_Mobilize_DirtyFlag_0&_Mobilize_Dirty_txtPassword)>0)
{yield return "txtPassword";
}
if((_Mobilize_DirtyFlag_0&_Mobilize_Dirty_cmdOK)>0)
{yield return "cmdOK";
}
if((_Mobilize_DirtyFlag_0&_Mobilize_Dirty__lblLabels_0)>0)
{yield return "_lblLabels_0";
}
if((_Mobilize_DirtyFlag_0&_Mobilize_Dirty__lblLabels_1)>0)
{yield return "_lblLabels_1";
}
if((_Mobilize_DirtyFlag_0&_Mobilize_Dirty_lblLabels)>0)
{yield return "lblLabels";
}
yield break ;
}
protected override bool _Mobilize_HasChanges(string propertyName)
{switch(propertyName){case "LoginSucceeded":return (_Mobilize_DirtyFlag_0&_Mobilize_Dirty_LoginSucceeded)>0;
case "visualControls":return (_Mobilize_DirtyFlag_0&_Mobilize_Dirty_visualControls)>0;
case "components":return (_Mobilize_DirtyFlag_0&_Mobilize_Dirty_components)>0;
case "ToolTipMain":return (_Mobilize_DirtyFlag_0&_Mobilize_Dirty_ToolTipMain)>0;
case "txtUserName":return (_Mobilize_DirtyFlag_0&_Mobilize_Dirty_txtUserName)>0;
case "cmdCancel":return (_Mobilize_DirtyFlag_0&_Mobilize_Dirty_cmdCancel)>0;
case "txtPassword":return (_Mobilize_DirtyFlag_0&_Mobilize_Dirty_txtPassword)>0;
case "cmdOK":return (_Mobilize_DirtyFlag_0&_Mobilize_Dirty_cmdOK)>0;
case "_lblLabels_0":return (_Mobilize_DirtyFlag_0&_Mobilize_Dirty__lblLabels_0)>0;
case "_lblLabels_1":return (_Mobilize_DirtyFlag_0&_Mobilize_Dirty__lblLabels_1)>0;
case "lblLabels":return (_Mobilize_DirtyFlag_0&_Mobilize_Dirty_lblLabels)>0;
}return base._Mobilize_HasChanges(propertyName);
}
protected override Mobilize.WebMap.Common.Core.ReferenceMap _Mobilize_GetReferenceMap(Mobilize.WebMap.Common.Core.ReferenceMap refs)
{base._Mobilize_GetReferenceMap(refs);refs["visualControls"]=_Mobilize_References[0];
refs["components"]=_Mobilize_References[1];
refs["ToolTipMain"]=_Mobilize_References[2];
refs["txtUserName"]=_Mobilize_References[3];
refs["cmdCancel"]=_Mobilize_References[4];
refs["txtPassword"]=_Mobilize_References[5];
refs["cmdOK"]=_Mobilize_References[6];
refs["_lblLabels_0"]=_Mobilize_References[7];
refs["_lblLabels_1"]=_Mobilize_References[8];
refs["lblLabels"]=_Mobilize_References[9];
return refs;
}
protected override void _Mobilize_CleanChanges()
{if(!((Mobilize.WebMap.Common.Core.ITrackable)this).IsNew||((Mobilize.WebMap.Common.Core.IObservable)this).RefCount>0)
{this._Mobilize_DirtyFlag_0=0;
this._Mobilize_LoadedFlag_0=0;
this._Mobilize_ControlFlag=0;
}
base._Mobilize_CleanChanges();}
protected override System.Collections.Generic.IEnumerable<Mobilize.WebMap.Common.Core.IObservable> _Mobilize_GetReferences()
{foreach ( var baseRef in base._Mobilize_GetReferences()) {yield return baseRef;
}var ref_visualControls=Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetAsObservable(this.visualControls);if(ref_visualControls!=null)yield return ref_visualControls;
var ref_components=Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetAsObservable(this.components);if(ref_components!=null)yield return ref_components;
var ref_ToolTipMain=Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetAsObservable(this.ToolTipMain);if(ref_ToolTipMain!=null)yield return ref_ToolTipMain;
var ref_txtUserName=(Mobilize.WebMap.Common.Core.IObservable)this.txtUserName;if(ref_txtUserName!=null)yield return ref_txtUserName;
var ref_cmdCancel=(Mobilize.WebMap.Common.Core.IObservable)this.cmdCancel;if(ref_cmdCancel!=null)yield return ref_cmdCancel;
var ref_txtPassword=(Mobilize.WebMap.Common.Core.IObservable)this.txtPassword;if(ref_txtPassword!=null)yield return ref_txtPassword;
var ref_cmdOK=(Mobilize.WebMap.Common.Core.IObservable)this.cmdOK;if(ref_cmdOK!=null)yield return ref_cmdOK;
var ref__lblLabels_0=(Mobilize.WebMap.Common.Core.IObservable)this._lblLabels_0;if(ref__lblLabels_0!=null)yield return ref__lblLabels_0;
var ref__lblLabels_1=(Mobilize.WebMap.Common.Core.IObservable)this._lblLabels_1;if(ref__lblLabels_1!=null)yield return ref__lblLabels_1;
var ref_lblLabels=Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetAsObservable(this.lblLabels);if(ref_lblLabels!=null)yield return ref_lblLabels;
yield break ;
}
private uint _Mobilize_DirtyFlag_0;
private uint _Mobilize_LoadedFlag_0;
const uint _Mobilize_Dirty_LoginSucceeded=(uint)1<<0;
const uint _Mobilize_Dirty_visualControls=(uint)1<<1;
const uint _Mobilize_Loaded_visualControls=(uint)1<<0;
const uint _Mobilize_Dirty_components=(uint)1<<2;
const uint _Mobilize_Loaded_components=(uint)1<<1;
const uint _Mobilize_Dirty_ToolTipMain=(uint)1<<3;
const uint _Mobilize_Loaded_ToolTipMain=(uint)1<<2;
const uint _Mobilize_Dirty_txtUserName=(uint)1<<4;
const uint _Mobilize_Loaded_txtUserName=(uint)1<<3;
const uint _Mobilize_Dirty_cmdCancel=(uint)1<<5;
const uint _Mobilize_Loaded_cmdCancel=(uint)1<<4;
const uint _Mobilize_Dirty_txtPassword=(uint)1<<6;
const uint _Mobilize_Loaded_txtPassword=(uint)1<<5;
const uint _Mobilize_Dirty_cmdOK=(uint)1<<7;
const uint _Mobilize_Loaded_cmdOK=(uint)1<<6;
const uint _Mobilize_Dirty__lblLabels_0=(uint)1<<8;
const uint _Mobilize_Loaded__lblLabels_0=(uint)1<<7;
const uint _Mobilize_Dirty__lblLabels_1=(uint)1<<9;
const uint _Mobilize_Loaded__lblLabels_1=(uint)1<<8;
const uint _Mobilize_Dirty_lblLabels=(uint)1<<10;
const uint _Mobilize_Loaded_lblLabels=(uint)1<<9;
private void Mobilize_Initialize_Properties()
{
#line 18
                                               this.LoginSucceeded=false;
#line hidden
 
#line 47
                                                    this.visualControls=new string[]{"components", "ToolTipMain", "txtUserName", "cmdCancel", "txtPassword", "cmdOK", "_lblLabels_0", "_lblLabels_1", "lblLabels"};
#line hidden
 
#line 76
                                                          this.lblLabels=new Mobilize.Web.Label[2];
#line hidden
 }
#line 13
    

#line hidden
                                               
[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private bool LoginSucceeded_k__BackingField;
#line 18
                                               

      [Intercepted]


      public bool LoginSucceeded 
#line 18
                                 { 
#line 18
                                   get                                      
#line hidden
{Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.Track(this);return this.LoginSucceeded_k__BackingField;} 
#line 18

#line 18
                                        set                                           
#line hidden
{_Mobilize_DirtyFlag_0|=_Mobilize_Dirty_LoginSucceeded;Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.Track(this);_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.LoginSucceeded_k__BackingField=(bool)value;} 
#line 18
                                             } 
#line 19


      public frmLogin()
      	: base()
      {

#line hidden
this.Mobilize_Initialize_Properties();
#line 23
      	if (m_vb6FormDefInstance == null)
         {
         	if (m_InitializingDefInstance)
         	{
         		m_vb6FormDefInstance = this;
         	}
         	else
         	{
         		try
         		{
         			//For the start-up form, the first instance created is the default instance.
         			if (System.Reflection.Assembly.GetExecutingAssembly().EntryPoint != null && System.Reflection.Assembly.GetExecutingAssembly().EntryPoint.DeclaringType == this.GetType())
                  {
                  	m_vb6FormDefInstance = this;
                  }
               }
               catch
               {
               }
            }
         }
         //This call is required by the Windows Form Designer.
         InitializeComponent();
         ReLoadForm(false);
      }



      private void cmdCancel_Click(Object eventSender, EventArgs eventArgs)
      {
      	LoginSucceeded = false;
      	this.Close();
      }

      private void cmdOk_Click(Object eventSender, EventArgs eventArgs)
      {
      	modConnection.ExecuteSql("SELECT * FROM Users WHERE username = '" + txtUserName.Text + "' and password = '" + txtPassword.Text + "'");
      	if (modConnection.rs.EOF)
      	{
            Mobilize.Web.MessageBox.Show("Invalid 'Username' or 'Password', please try again!", System.Diagnostics.FileVersionInfo.GetVersionInfo(System.Reflection.Assembly.GetExecutingAssembly().Location).ProductName, Mobilize.Web.MessageBoxButtons.OK, Mobilize.Web.MessageBoxIcon.Exclamation);
            txtUserName.Focus();
            modFunctions.SelectAll(txtUserName);
            return;
         }
         modMain.UserFullname = Convert.ToString(modConnection.rs["Fullname"]);
         modMain.UserLevel = Convert.ToString(modConnection.rs["Level"]);
         modMain.CurrentUserAdmin = (modMain.UserLevel == "Administrator");
         this.Properties().Cursor = null;
         LoginSucceeded = true;
         modMain.LogStatus("User : " + modMain.UserFullname + " logged at " + DateTimeHelper.ToString(DateTime.Parse(DateTimeHelper.ToString(DateTime.Now))) + "," + DateTimeHelper.ToString(DateTime.Now));
         this.Close();
      }

      private void Form_Closed(Object eventSender, EventArgs eventArgs)
      {
      }
public class _Mobilize_SharedState :Mobilize.WebMap.Common.Core.IObservable,Mobilize.WebMap.Common.Core.IDelta{
#line hidden
private Mobilize.WebMap.Common.Core.Identifier[] _Mobilize_References=new Mobilize.WebMap.Common.Core.Identifier[1];
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
{refs["m_vb6FormDefInstance"]=_Mobilize_References[0];
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
protected virtual System.Collections.Generic.IEnumerable<Mobilize.WebMap.Common.Core.IObservable> _Mobilize_GetReferences(){var ref_m_vb6FormDefInstance=(Mobilize.WebMap.Common.Core.IObservable)this.m_vb6FormDefInstance;if(ref_m_vb6FormDefInstance!=null)yield return ref_m_vb6FormDefInstance;
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
{if((_Mobilize_DirtyFlag_0&_Mobilize_Dirty_m_vb6FormDefInstance)>0)
{yield return "m_vb6FormDefInstance";
}
if((_Mobilize_DirtyFlag_0&_Mobilize_Dirty_m_InitializingDefInstance)>0)
{yield return "m_InitializingDefInstance";
}
yield break ;
}
protected virtual bool _Mobilize_HasChanges(string propertyName)
{switch(propertyName){case "m_vb6FormDefInstance":return (_Mobilize_DirtyFlag_0&_Mobilize_Dirty_m_vb6FormDefInstance)>0;
case "m_InitializingDefInstance":return (_Mobilize_DirtyFlag_0&_Mobilize_Dirty_m_InitializingDefInstance)>0;
}return false;
}
private uint _Mobilize_DirtyFlag_0;
private uint _Mobilize_LoadedFlag_0;
const uint _Mobilize_Dirty_m_vb6FormDefInstance=(uint)1<<0;
const uint _Mobilize_Loaded_m_vb6FormDefInstance=(uint)1<<0;
const uint _Mobilize_Dirty_m_InitializingDefInstance=(uint)1<<1;

#line hidden

[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private SKS.frmLogin m_vb6FormDefInstance_k__BackingField;
internal object m_vb6FormDefInstance {get
#line hidden
{if((_Mobilize_LoadedFlag_0&_Mobilize_Loaded_m_vb6FormDefInstance)<=0){this.m_vb6FormDefInstance_k__BackingField=Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetObservable<SKS.frmLogin>(this,_Mobilize_References,0);_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_m_vb6FormDefInstance;;} return this.m_vb6FormDefInstance_k__BackingField; }set
#line hidden
{if(Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.SetObservable<SKS.frmLogin>(this,_Mobilize_References,0,this.m_vb6FormDefInstance_k__BackingField,(SKS.frmLogin)value)){_Mobilize_DirtyFlag_0|=_Mobilize_Dirty_m_vb6FormDefInstance;}_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_m_vb6FormDefInstance;_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.m_vb6FormDefInstance_k__BackingField=(SKS.frmLogin)value;}}
#line hidden

[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private bool m_InitializingDefInstance_k__BackingField;
internal bool m_InitializingDefInstance {get
#line hidden
{Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.Track(this);return this.m_InitializingDefInstance_k__BackingField;}set
#line hidden
{_Mobilize_DirtyFlag_0|=_Mobilize_Dirty_m_InitializingDefInstance;Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.Track(this);_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.m_InitializingDefInstance_k__BackingField=(bool)value;}}}
   }
}
#pragma warning restore

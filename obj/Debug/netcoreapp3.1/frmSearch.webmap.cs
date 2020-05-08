#pragma warning disable
#line 1 "frmSearch.cs"
#pragma warning disable
#line 1 "frmSearch.cs"
using System;
using UpgradeHelpers.DB.ADO;
using Mobilize.WebMap.Common.Attributes;
using Mobilize.Web.Extensions;

namespace SKS
{

   [Observable]
   internal partial class frmSearch
      : Mobilize.Web.Form
   {
#line hidden
private Mobilize.WebMap.Common.Core.Identifier[] _Mobilize_References=new Mobilize.WebMap.Common.Core.Identifier[13];
protected override System.Collections.Generic.IEnumerable<string> _Mobilize_GetChanges()
{
foreach(var item in base._Mobilize_GetChanges())

{yield return item;}
if((_Mobilize_DirtyFlag_0&_Mobilize_Dirty_SearchTable)>0)
{yield return "SearchTable";
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
if((_Mobilize_DirtyFlag_0&_Mobilize_Dirty_cmdClose)>0)
{yield return "cmdClose";
}
if((_Mobilize_DirtyFlag_0&_Mobilize_Dirty_cmdSearch)>0)
{yield return "cmdSearch";
}
if((_Mobilize_DirtyFlag_0&_Mobilize_Dirty_ctrlLiner1)>0)
{yield return "ctrlLiner1";
}
if((_Mobilize_DirtyFlag_0&_Mobilize_Dirty_cboSrchBy)>0)
{yield return "cboSrchBy";
}
if((_Mobilize_DirtyFlag_0&_Mobilize_Dirty_txtSrchStr)>0)
{yield return "txtSrchStr";
}
if((_Mobilize_DirtyFlag_0&_Mobilize_Dirty_Label20)>0)
{yield return "Label20";
}
if((_Mobilize_DirtyFlag_0&_Mobilize_Dirty_Label19)>0)
{yield return "Label19";
}
if((_Mobilize_DirtyFlag_0&_Mobilize_Dirty_Image3)>0)
{yield return "Image3";
}
if((_Mobilize_DirtyFlag_0&_Mobilize_Dirty_Label1)>0)
{yield return "Label1";
}
if((_Mobilize_DirtyFlag_0&_Mobilize_Dirty_lblSrchBy)>0)
{yield return "lblSrchBy";
}
yield break ;
}
protected override bool _Mobilize_HasChanges(string propertyName)
{switch(propertyName){case "SearchTable":return (_Mobilize_DirtyFlag_0&_Mobilize_Dirty_SearchTable)>0;
case "visualControls":return (_Mobilize_DirtyFlag_0&_Mobilize_Dirty_visualControls)>0;
case "components":return (_Mobilize_DirtyFlag_0&_Mobilize_Dirty_components)>0;
case "ToolTipMain":return (_Mobilize_DirtyFlag_0&_Mobilize_Dirty_ToolTipMain)>0;
case "cmdClose":return (_Mobilize_DirtyFlag_0&_Mobilize_Dirty_cmdClose)>0;
case "cmdSearch":return (_Mobilize_DirtyFlag_0&_Mobilize_Dirty_cmdSearch)>0;
case "ctrlLiner1":return (_Mobilize_DirtyFlag_0&_Mobilize_Dirty_ctrlLiner1)>0;
case "cboSrchBy":return (_Mobilize_DirtyFlag_0&_Mobilize_Dirty_cboSrchBy)>0;
case "txtSrchStr":return (_Mobilize_DirtyFlag_0&_Mobilize_Dirty_txtSrchStr)>0;
case "Label20":return (_Mobilize_DirtyFlag_0&_Mobilize_Dirty_Label20)>0;
case "Label19":return (_Mobilize_DirtyFlag_0&_Mobilize_Dirty_Label19)>0;
case "Image3":return (_Mobilize_DirtyFlag_0&_Mobilize_Dirty_Image3)>0;
case "Label1":return (_Mobilize_DirtyFlag_0&_Mobilize_Dirty_Label1)>0;
case "lblSrchBy":return (_Mobilize_DirtyFlag_0&_Mobilize_Dirty_lblSrchBy)>0;
}return base._Mobilize_HasChanges(propertyName);
}
protected override Mobilize.WebMap.Common.Core.ReferenceMap _Mobilize_GetReferenceMap(Mobilize.WebMap.Common.Core.ReferenceMap refs)
{base._Mobilize_GetReferenceMap(refs);refs["visualControls"]=_Mobilize_References[0];
refs["components"]=_Mobilize_References[1];
refs["ToolTipMain"]=_Mobilize_References[2];
refs["cmdClose"]=_Mobilize_References[3];
refs["cmdSearch"]=_Mobilize_References[4];
refs["ctrlLiner1"]=_Mobilize_References[5];
refs["cboSrchBy"]=_Mobilize_References[6];
refs["txtSrchStr"]=_Mobilize_References[7];
refs["Label20"]=_Mobilize_References[8];
refs["Label19"]=_Mobilize_References[9];
refs["Image3"]=_Mobilize_References[10];
refs["Label1"]=_Mobilize_References[11];
refs["lblSrchBy"]=_Mobilize_References[12];
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
var ref_cmdClose=(Mobilize.WebMap.Common.Core.IObservable)this.cmdClose;if(ref_cmdClose!=null)yield return ref_cmdClose;
var ref_cmdSearch=(Mobilize.WebMap.Common.Core.IObservable)this.cmdSearch;if(ref_cmdSearch!=null)yield return ref_cmdSearch;
var ref_ctrlLiner1=(Mobilize.WebMap.Common.Core.IObservable)this.ctrlLiner1;if(ref_ctrlLiner1!=null)yield return ref_ctrlLiner1;
var ref_cboSrchBy=(Mobilize.WebMap.Common.Core.IObservable)this.cboSrchBy;if(ref_cboSrchBy!=null)yield return ref_cboSrchBy;
var ref_txtSrchStr=(Mobilize.WebMap.Common.Core.IObservable)this.txtSrchStr;if(ref_txtSrchStr!=null)yield return ref_txtSrchStr;
var ref_Label20=(Mobilize.WebMap.Common.Core.IObservable)this.Label20;if(ref_Label20!=null)yield return ref_Label20;
var ref_Label19=(Mobilize.WebMap.Common.Core.IObservable)this.Label19;if(ref_Label19!=null)yield return ref_Label19;
var ref_Image3=(Mobilize.WebMap.Common.Core.IObservable)this.Image3;if(ref_Image3!=null)yield return ref_Image3;
var ref_Label1=(Mobilize.WebMap.Common.Core.IObservable)this.Label1;if(ref_Label1!=null)yield return ref_Label1;
var ref_lblSrchBy=(Mobilize.WebMap.Common.Core.IObservable)this.lblSrchBy;if(ref_lblSrchBy!=null)yield return ref_lblSrchBy;
yield break ;
}
private uint _Mobilize_DirtyFlag_0;
private uint _Mobilize_LoadedFlag_0;
const uint _Mobilize_Dirty_SearchTable=(uint)1<<0;
const uint _Mobilize_Dirty_visualControls=(uint)1<<1;
const uint _Mobilize_Loaded_visualControls=(uint)1<<0;
const uint _Mobilize_Dirty_components=(uint)1<<2;
const uint _Mobilize_Loaded_components=(uint)1<<1;
const uint _Mobilize_Dirty_ToolTipMain=(uint)1<<3;
const uint _Mobilize_Loaded_ToolTipMain=(uint)1<<2;
const uint _Mobilize_Dirty_cmdClose=(uint)1<<4;
const uint _Mobilize_Loaded_cmdClose=(uint)1<<3;
const uint _Mobilize_Dirty_cmdSearch=(uint)1<<5;
const uint _Mobilize_Loaded_cmdSearch=(uint)1<<4;
const uint _Mobilize_Dirty_ctrlLiner1=(uint)1<<6;
const uint _Mobilize_Loaded_ctrlLiner1=(uint)1<<5;
const uint _Mobilize_Dirty_cboSrchBy=(uint)1<<7;
const uint _Mobilize_Loaded_cboSrchBy=(uint)1<<6;
const uint _Mobilize_Dirty_txtSrchStr=(uint)1<<8;
const uint _Mobilize_Loaded_txtSrchStr=(uint)1<<7;
const uint _Mobilize_Dirty_Label20=(uint)1<<9;
const uint _Mobilize_Loaded_Label20=(uint)1<<8;
const uint _Mobilize_Dirty_Label19=(uint)1<<10;
const uint _Mobilize_Loaded_Label19=(uint)1<<9;
const uint _Mobilize_Dirty_Image3=(uint)1<<11;
const uint _Mobilize_Loaded_Image3=(uint)1<<10;
const uint _Mobilize_Dirty_Label1=(uint)1<<12;
const uint _Mobilize_Loaded_Label1=(uint)1<<11;
const uint _Mobilize_Dirty_lblSrchBy=(uint)1<<13;
const uint _Mobilize_Loaded_lblSrchBy=(uint)1<<12;
private void Mobilize_Initialize_Properties()
{
#line 16
                                       this.SearchTable="";
#line hidden
 
#line 47
                                                    this.visualControls=new string[]{"components", "ToolTipMain", "cmdClose", "cmdSearch", "ctrlLiner1", "cboSrchBy", "txtSrchStr", "Label20", "Label19", "Image3", "Label1", "lblSrchBy"};
#line hidden
 }
#line 12
    

#line hidden
                                       
[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private string SearchTable_k__BackingField;
#line 16
                                       

      [Intercepted]

      string SearchTable 
#line 16
                         { 
#line 16
                           get                              
#line hidden
{Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.Track(this);return this.SearchTable_k__BackingField;} 
#line 16

#line 16
                                set                                   
#line hidden
{_Mobilize_DirtyFlag_0|=_Mobilize_Dirty_SearchTable;Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.Track(this);_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.SearchTable_k__BackingField=(string)value;} 
#line 16
                                     } 
#line 17


      public frmSearch()
      	: base()
      {

#line hidden
this.Mobilize_Initialize_Properties();
#line 21
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
      }


      private void cboSrchBy_SelectedIndexChanged(Object eventSender, EventArgs eventArgs)
      {
      	lblSrchBy.Text = cboSrchBy.Text;
      }

      private void cmdClose_Click(Object eventSender, EventArgs eventArgs)
      {
      	this.Close();
      }


      public void Search(string Table, string fieldToSearch, string itemToSearch)
      {
      	//UPGRADE_WARNING: (2080) IsEmpty was upgraded to a comparison and has a new behavior. More Information: https://www.mobilize.net/vbtonet/ewis/ewi2080
      	if (!String.IsNullOrEmpty(itemToSearch))
      	{
      		Label20.Text = "Search for a " + itemToSearch;
      	}
      	SearchTable = Table;
      	modConnection.ExecuteSql("Select * from " + Table + " limit 1;");
      	int tempForEndVar = (modConnection.rs.FieldsMetadata.Count - 1);
      	for (modMain.i = 0; modMain.i <= tempForEndVar; modMain.i++)
      	{
      		cboSrchBy.AddItem(modConnection.rs.GetField(modMain.i).FieldMetadata.ColumnName);
      	}
      	cboSrchBy.Text = fieldToSearch;
      }

      private void cmdSearch_Click(Object eventSender, EventArgs eventArgs)
      {
      	if (txtSrchStr.Text.Substring(Math.Max(txtSrchStr.Text.Length - 1, 0)) == "'")
         {
         	txtSrchStr.Text = "";
         }
         string txtToSearch = "";

         //UPGRADE_WARNING: (2080) IsEmpty was upgraded to a comparison and has a new behavior. More Information: https://www.mobilize.net/vbtonet/ewis/ewi2080
         if (!String.IsNullOrEmpty(txtSrchStr.Text.Trim()))
         {
         	txtToSearch = txtSrchStr.Text;
         }
         else
         {
         	txtToSearch = "%";
         }
         if (SearchTable == "Customers")
         {
         	SearchCriteriaCustomers(lblSrchBy.Text, txtToSearch);
         }
         else if (SearchTable == "Products")
         {
         	SearchCriteriaProducts(lblSrchBy.Text, txtToSearch);
         }
         else if (SearchTable == "Providers")
         {
         	SearchCriteriaProviders(lblSrchBy.Text, txtToSearch);
         }
      }

      //''

      public void SearchCriteriaCustomers(string field, string value)
      {
      	modConnection.ExecuteSql("Select * from Customers where " + field + " LIKE '" + value + "%'");
      	if (modConnection.rs.RecordCount == 0)
         {
            Mobilize.Web.MessageBox.Show("There are no records with the selected criteria", "Search", Mobilize.Web.MessageBoxButtons.OK, Mobilize.Web.MessageBoxIcon.Information);
         }
         else
         {
         	modMain.LogStatus("There are " + modConnection.rs.RecordCount.ToString() + " that meet with the selected criteria");
         	frmCustomers.DefInstance.dcCustomers.Recordset = modConnection.rs;
         }
      }

      public void SearchCriteriaProducts(string field, string value)
      {
      	modConnection.ExecuteSql("Select * from Products where " + field + " LIKE '" + value + "%'");
      	if (modConnection.rs.RecordCount == 0)
         {
            Mobilize.Web.MessageBox.Show("There are no records with the selected criteria", "Search", Mobilize.Web.MessageBoxButtons.OK, Mobilize.Web.MessageBoxIcon.Information);
         }
         else
         {
         	frmProducts.DefInstance.dcProducts.Recordset = modConnection.rs;
         }
      }

      public void SearchCriteriaProviders(string field, string value)
      {
      	modConnection.ExecuteSql("Select * from Providers where " + field + " LIKE '" + value + "%'");
      	if (modConnection.rs.RecordCount == 0)
         {
            Mobilize.Web.MessageBox.Show("There are no records with the selected criteria", "Search", Mobilize.Web.MessageBoxButtons.OK, Mobilize.Web.MessageBoxIcon.Information);
         }
         else
         {
         	modMain.LogStatus("There are " + modConnection.rs.RecordCount.ToString() + " that meet with the selected criteria");
         	frmProviders.DefInstance.dcProviders.Recordset = modConnection.rs;
         }
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
private SKS.frmSearch m_vb6FormDefInstance_k__BackingField;
internal object m_vb6FormDefInstance {get
#line hidden
{if((_Mobilize_LoadedFlag_0&_Mobilize_Loaded_m_vb6FormDefInstance)<=0){this.m_vb6FormDefInstance_k__BackingField=Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetObservable<SKS.frmSearch>(this,_Mobilize_References,0);_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_m_vb6FormDefInstance;;} return this.m_vb6FormDefInstance_k__BackingField; }set
#line hidden
{if(Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.SetObservable<SKS.frmSearch>(this,_Mobilize_References,0,this.m_vb6FormDefInstance_k__BackingField,(SKS.frmSearch)value)){_Mobilize_DirtyFlag_0|=_Mobilize_Dirty_m_vb6FormDefInstance;}_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_m_vb6FormDefInstance;_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.m_vb6FormDefInstance_k__BackingField=(SKS.frmSearch)value;}}
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

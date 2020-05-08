#pragma warning disable
#line 1 ""
#line hidden
public class _Mobilize_AssemblySharedStateCatalog : Mobilize.WebMap.Common.Core.Static.IStaticSlot, Mobilize.WebMap.Common.Core.IObservable, Mobilize.WebMap.Common.Core.IDelta
{
#line hidden
    private Mobilize.WebMap.Common.Core.Identifier[] _Mobilize_References = new Mobilize.WebMap.Common.Core.Identifier[21];
    Mobilize.WebMap.Common.Core.Identifier Mobilize.WebMap.Common.Core.IObservable.MobilizeId
    {
        get;
        set;
    }

    = Mobilize.WebMap.Common.Core.Context.CoreContext.Services.IdentifierService.GetIdentifier();
    Mobilize.WebMap.Common.Core.ReferenceMap Mobilize.WebMap.Common.Core.IObservable.References
    {
        get => this._Mobilize_GetReferenceMap(new Mobilize.WebMap.Common.Core.ReferenceMap());
        set => throw new System.NotImplementedException();
    }

    protected uint _Mobilize_ControlFlag = 1;
    bool Mobilize.WebMap.Common.Core.ITrackable.IsNew
    {
        get => (this._Mobilize_ControlFlag & _Mobilize_IsNew_Flag) > 0;
        set => _Mobilize_ControlFlag = value ? this._Mobilize_ControlFlag = 1 << 0 : this._Mobilize_ControlFlag & 0 << 0;
    }

    Mobilize.WebMap.Common.Core.IDelta Mobilize.WebMap.Common.Core.ITrackable.Delta => this;
    void Mobilize.WebMap.Common.Core.ITrackable.CleanChanges() => _Mobilize_CleanChanges();
    protected virtual void _Mobilize_CleanChanges()
    {
        if (!((Mobilize.WebMap.Common.Core.ITrackable)this).IsNew || ((Mobilize.WebMap.Common.Core.IObservable)this).RefCount > 0)
        {
            this._Mobilize_DirtyFlag_0 = 0;
            this._Mobilize_LoadedFlag_0 = 0;
            this._Mobilize_ControlFlag = 0;
        }
    }

    protected virtual Mobilize.WebMap.Common.Core.ReferenceMap _Mobilize_GetReferenceMap(Mobilize.WebMap.Common.Core.ReferenceMap refs)
    {
        refs["Next"] = _Mobilize_References[0];
        refs["frmAbout"] = _Mobilize_References[1];
        refs["frmActionOrderReception"] = _Mobilize_References[2];
        refs["frmActionOrderRequest"] = _Mobilize_References[3];
        refs["frmAddProductTo"] = _Mobilize_References[4];
        refs["frmAddStockManual"] = _Mobilize_References[5];
        refs["frmAdjustStockManual"] = _Mobilize_References[6];
        refs["frmCustomers"] = _Mobilize_References[7];
        refs["frmLogin"] = _Mobilize_References[8];
        refs["frmMain"] = _Mobilize_References[9];
        refs["frmReceptionApproval"] = _Mobilize_References[10];
        refs["frmOrderReception"] = _Mobilize_References[11];
        refs["frmOrderRequest"] = _Mobilize_References[12];
        refs["frmProducts"] = _Mobilize_References[13];
        refs["frmProviders"] = _Mobilize_References[14];
        refs["frmRequestApproval"] = _Mobilize_References[15];
        refs["frmSearch"] = _Mobilize_References[16];
        refs["frmSplash"] = _Mobilize_References[17];
        refs["frmUsersManage"] = _Mobilize_References[18];
        refs["modConnection"] = _Mobilize_References[19];
        refs["modMain"] = _Mobilize_References[20];
        return refs;
    }

    private int _Mobilize_RefCount = 0;
    int Mobilize.WebMap.Common.Core.IObservable.DecrementRefCount()
    {
        return System.Threading.Interlocked.Decrement(ref _Mobilize_RefCount);
    }

    int Mobilize.WebMap.Common.Core.IObservable.IncrementRefCount()
    {
        return System.Threading.Interlocked.Increment(ref _Mobilize_RefCount);
    }

    int Mobilize.WebMap.Common.Core.IObservable.RefCount
    {
        get
        {
            return _Mobilize_RefCount;
        }
    }

    System.Collections.Generic.IEnumerable<Mobilize.WebMap.Common.Core.IObservable> Mobilize.WebMap.Common.Core.IObservable.GetReferences()
    {
        return this._Mobilize_GetReferences();
    }

    protected virtual System.Collections.Generic.IEnumerable<Mobilize.WebMap.Common.Core.IObservable> _Mobilize_GetReferences()
    {
        var ref_Next = (Mobilize.WebMap.Common.Core.IObservable)this.Next;
        if (ref_Next != null)
            yield return ref_Next;
        var ref_frmAbout = (Mobilize.WebMap.Common.Core.IObservable)this.frmAbout;
        if (ref_frmAbout != null)
            yield return ref_frmAbout;
        var ref_frmActionOrderReception = (Mobilize.WebMap.Common.Core.IObservable)this.frmActionOrderReception;
        if (ref_frmActionOrderReception != null)
            yield return ref_frmActionOrderReception;
        var ref_frmActionOrderRequest = (Mobilize.WebMap.Common.Core.IObservable)this.frmActionOrderRequest;
        if (ref_frmActionOrderRequest != null)
            yield return ref_frmActionOrderRequest;
        var ref_frmAddProductTo = (Mobilize.WebMap.Common.Core.IObservable)this.frmAddProductTo;
        if (ref_frmAddProductTo != null)
            yield return ref_frmAddProductTo;
        var ref_frmAddStockManual = (Mobilize.WebMap.Common.Core.IObservable)this.frmAddStockManual;
        if (ref_frmAddStockManual != null)
            yield return ref_frmAddStockManual;
        var ref_frmAdjustStockManual = (Mobilize.WebMap.Common.Core.IObservable)this.frmAdjustStockManual;
        if (ref_frmAdjustStockManual != null)
            yield return ref_frmAdjustStockManual;
        var ref_frmCustomers = (Mobilize.WebMap.Common.Core.IObservable)this.frmCustomers;
        if (ref_frmCustomers != null)
            yield return ref_frmCustomers;
        var ref_frmLogin = (Mobilize.WebMap.Common.Core.IObservable)this.frmLogin;
        if (ref_frmLogin != null)
            yield return ref_frmLogin;
        var ref_frmMain = (Mobilize.WebMap.Common.Core.IObservable)this.frmMain;
        if (ref_frmMain != null)
            yield return ref_frmMain;
        var ref_frmReceptionApproval = (Mobilize.WebMap.Common.Core.IObservable)this.frmReceptionApproval;
        if (ref_frmReceptionApproval != null)
            yield return ref_frmReceptionApproval;
        var ref_frmOrderReception = (Mobilize.WebMap.Common.Core.IObservable)this.frmOrderReception;
        if (ref_frmOrderReception != null)
            yield return ref_frmOrderReception;
        var ref_frmOrderRequest = (Mobilize.WebMap.Common.Core.IObservable)this.frmOrderRequest;
        if (ref_frmOrderRequest != null)
            yield return ref_frmOrderRequest;
        var ref_frmProducts = (Mobilize.WebMap.Common.Core.IObservable)this.frmProducts;
        if (ref_frmProducts != null)
            yield return ref_frmProducts;
        var ref_frmProviders = (Mobilize.WebMap.Common.Core.IObservable)this.frmProviders;
        if (ref_frmProviders != null)
            yield return ref_frmProviders;
        var ref_frmRequestApproval = (Mobilize.WebMap.Common.Core.IObservable)this.frmRequestApproval;
        if (ref_frmRequestApproval != null)
            yield return ref_frmRequestApproval;
        var ref_frmSearch = (Mobilize.WebMap.Common.Core.IObservable)this.frmSearch;
        if (ref_frmSearch != null)
            yield return ref_frmSearch;
        var ref_frmSplash = (Mobilize.WebMap.Common.Core.IObservable)this.frmSplash;
        if (ref_frmSplash != null)
            yield return ref_frmSplash;
        var ref_frmUsersManage = (Mobilize.WebMap.Common.Core.IObservable)this.frmUsersManage;
        if (ref_frmUsersManage != null)
            yield return ref_frmUsersManage;
        var ref_modConnection = (Mobilize.WebMap.Common.Core.IObservable)this.modConnection;
        if (ref_modConnection != null)
            yield return ref_modConnection;
        var ref_modMain = (Mobilize.WebMap.Common.Core.IObservable)this.modMain;
        if (ref_modMain != null)
            yield return ref_modMain;
        yield break;
    }

    const uint _Mobilize_IsNew_Flag = (uint)1 << 0;
    protected const uint _Mobilize_HasChanged_Flag = (uint)1 << 1;
    bool Mobilize.WebMap.Common.Core.ITrackable.HasChanged
    {
        get => (this._Mobilize_ControlFlag & _Mobilize_HasChanged_Flag) > 0;
    }

    const uint _Mobilize_IsRefresh_Flag = (uint)1 << 2;
    bool Mobilize.WebMap.Common.Core.ITrackable.IsRefresh
    {
        get => (this._Mobilize_ControlFlag & _Mobilize_IsRefresh_Flag) > 0;
        set => _Mobilize_ControlFlag = value ? this._Mobilize_ControlFlag = 1 << 2 : this._Mobilize_ControlFlag & 0 << 2;
    }

    const uint _Mobilize_IsMarked_Flag = (uint)1 << 3;
    bool Mobilize.WebMap.Common.Core.ITrackable.IsMarked
    {
        get => (this._Mobilize_ControlFlag & _Mobilize_IsMarked_Flag) > 0;
        set => _Mobilize_ControlFlag = value ? this._Mobilize_ControlFlag = 1 << 3 : this._Mobilize_ControlFlag & 0 << 3;
    }

    bool Mobilize.WebMap.Common.Core.IDelta.IsNew
    {
        get => (this._Mobilize_ControlFlag & _Mobilize_IsNew_Flag) > 0;
        set => _Mobilize_ControlFlag = value ? this._Mobilize_ControlFlag = 1 << 0 : this._Mobilize_ControlFlag & 0 << 0;
    }

    Mobilize.WebMap.Common.Core.IObservable Mobilize.WebMap.Common.Core.IDelta.Target
    {
        get => this;
        set => throw new System.NotImplementedException();
    }

    System.Collections.Generic.IEnumerable<string> Mobilize.WebMap.Common.Core.IDelta.Changes => this._Mobilize_GetChanges();
    bool Mobilize.WebMap.Common.Core.IDelta.HasChanges(string propertyName) => this._Mobilize_HasChanges(propertyName);
    protected virtual System.Collections.Generic.IEnumerable<string> _Mobilize_GetChanges()
    {
        if ((_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_Next) > 0)
        {
            yield return "Next";
        }

        if ((_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_frmAbout) > 0)
        {
            yield return "frmAbout";
        }

        if ((_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_frmActionOrderReception) > 0)
        {
            yield return "frmActionOrderReception";
        }

        if ((_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_frmActionOrderRequest) > 0)
        {
            yield return "frmActionOrderRequest";
        }

        if ((_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_frmAddProductTo) > 0)
        {
            yield return "frmAddProductTo";
        }

        if ((_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_frmAddStockManual) > 0)
        {
            yield return "frmAddStockManual";
        }

        if ((_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_frmAdjustStockManual) > 0)
        {
            yield return "frmAdjustStockManual";
        }

        if ((_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_frmCustomers) > 0)
        {
            yield return "frmCustomers";
        }

        if ((_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_frmLogin) > 0)
        {
            yield return "frmLogin";
        }

        if ((_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_frmMain) > 0)
        {
            yield return "frmMain";
        }

        if ((_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_frmReceptionApproval) > 0)
        {
            yield return "frmReceptionApproval";
        }

        if ((_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_frmOrderReception) > 0)
        {
            yield return "frmOrderReception";
        }

        if ((_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_frmOrderRequest) > 0)
        {
            yield return "frmOrderRequest";
        }

        if ((_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_frmProducts) > 0)
        {
            yield return "frmProducts";
        }

        if ((_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_frmProviders) > 0)
        {
            yield return "frmProviders";
        }

        if ((_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_frmRequestApproval) > 0)
        {
            yield return "frmRequestApproval";
        }

        if ((_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_frmSearch) > 0)
        {
            yield return "frmSearch";
        }

        if ((_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_frmSplash) > 0)
        {
            yield return "frmSplash";
        }

        if ((_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_frmUsersManage) > 0)
        {
            yield return "frmUsersManage";
        }

        if ((_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_modConnection) > 0)
        {
            yield return "modConnection";
        }

        if ((_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_modMain) > 0)
        {
            yield return "modMain";
        }

        yield break;
    }

    protected virtual bool _Mobilize_HasChanges(string propertyName)
    {
        switch (propertyName)
        {
            case "Next":
                return (_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_Next) > 0;
            case "frmAbout":
                return (_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_frmAbout) > 0;
            case "frmActionOrderReception":
                return (_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_frmActionOrderReception) > 0;
            case "frmActionOrderRequest":
                return (_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_frmActionOrderRequest) > 0;
            case "frmAddProductTo":
                return (_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_frmAddProductTo) > 0;
            case "frmAddStockManual":
                return (_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_frmAddStockManual) > 0;
            case "frmAdjustStockManual":
                return (_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_frmAdjustStockManual) > 0;
            case "frmCustomers":
                return (_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_frmCustomers) > 0;
            case "frmLogin":
                return (_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_frmLogin) > 0;
            case "frmMain":
                return (_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_frmMain) > 0;
            case "frmReceptionApproval":
                return (_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_frmReceptionApproval) > 0;
            case "frmOrderReception":
                return (_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_frmOrderReception) > 0;
            case "frmOrderRequest":
                return (_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_frmOrderRequest) > 0;
            case "frmProducts":
                return (_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_frmProducts) > 0;
            case "frmProviders":
                return (_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_frmProviders) > 0;
            case "frmRequestApproval":
                return (_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_frmRequestApproval) > 0;
            case "frmSearch":
                return (_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_frmSearch) > 0;
            case "frmSplash":
                return (_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_frmSplash) > 0;
            case "frmUsersManage":
                return (_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_frmUsersManage) > 0;
            case "modConnection":
                return (_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_modConnection) > 0;
            case "modMain":
                return (_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_modMain) > 0;
        }

        return false;
    }

    private uint _Mobilize_DirtyFlag_0;
    private uint _Mobilize_LoadedFlag_0;
    const uint _Mobilize_Dirty_Next = (uint)1 << 0;
    const uint _Mobilize_Loaded_Next = (uint)1 << 0;
    const uint _Mobilize_Dirty_frmAbout = (uint)1 << 1;
    const uint _Mobilize_Loaded_frmAbout = (uint)1 << 1;
    const uint _Mobilize_Dirty_frmActionOrderReception = (uint)1 << 2;
    const uint _Mobilize_Loaded_frmActionOrderReception = (uint)1 << 2;
    const uint _Mobilize_Dirty_frmActionOrderRequest = (uint)1 << 3;
    const uint _Mobilize_Loaded_frmActionOrderRequest = (uint)1 << 3;
    const uint _Mobilize_Dirty_frmAddProductTo = (uint)1 << 4;
    const uint _Mobilize_Loaded_frmAddProductTo = (uint)1 << 4;
    const uint _Mobilize_Dirty_frmAddStockManual = (uint)1 << 5;
    const uint _Mobilize_Loaded_frmAddStockManual = (uint)1 << 5;
    const uint _Mobilize_Dirty_frmAdjustStockManual = (uint)1 << 6;
    const uint _Mobilize_Loaded_frmAdjustStockManual = (uint)1 << 6;
    const uint _Mobilize_Dirty_frmCustomers = (uint)1 << 7;
    const uint _Mobilize_Loaded_frmCustomers = (uint)1 << 7;
    const uint _Mobilize_Dirty_frmLogin = (uint)1 << 8;
    const uint _Mobilize_Loaded_frmLogin = (uint)1 << 8;
    const uint _Mobilize_Dirty_frmMain = (uint)1 << 9;
    const uint _Mobilize_Loaded_frmMain = (uint)1 << 9;
    const uint _Mobilize_Dirty_frmReceptionApproval = (uint)1 << 10;
    const uint _Mobilize_Loaded_frmReceptionApproval = (uint)1 << 10;
    const uint _Mobilize_Dirty_frmOrderReception = (uint)1 << 11;
    const uint _Mobilize_Loaded_frmOrderReception = (uint)1 << 11;
    const uint _Mobilize_Dirty_frmOrderRequest = (uint)1 << 12;
    const uint _Mobilize_Loaded_frmOrderRequest = (uint)1 << 12;
    const uint _Mobilize_Dirty_frmProducts = (uint)1 << 13;
    const uint _Mobilize_Loaded_frmProducts = (uint)1 << 13;
    const uint _Mobilize_Dirty_frmProviders = (uint)1 << 14;
    const uint _Mobilize_Loaded_frmProviders = (uint)1 << 14;
    const uint _Mobilize_Dirty_frmRequestApproval = (uint)1 << 15;
    const uint _Mobilize_Loaded_frmRequestApproval = (uint)1 << 15;
    const uint _Mobilize_Dirty_frmSearch = (uint)1 << 16;
    const uint _Mobilize_Loaded_frmSearch = (uint)1 << 16;
    const uint _Mobilize_Dirty_frmSplash = (uint)1 << 17;
    const uint _Mobilize_Loaded_frmSplash = (uint)1 << 17;
    const uint _Mobilize_Dirty_frmUsersManage = (uint)1 << 18;
    const uint _Mobilize_Loaded_frmUsersManage = (uint)1 << 18;
    const uint _Mobilize_Dirty_modConnection = (uint)1 << 19;
    const uint _Mobilize_Loaded_modConnection = (uint)1 << 19;
    const uint _Mobilize_Dirty_modMain = (uint)1 << 20;
    const uint _Mobilize_Loaded_modMain = (uint)1 << 20;
    public static string Key = typeof(_Mobilize_AssemblySharedStateCatalog).AssemblyQualifiedName;
    public static _Mobilize_AssemblySharedStateCatalog GetCached()
    {
        var catalog = Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetAssemblySharedStateCatalog<_Mobilize_AssemblySharedStateCatalog>(Key);
        return catalog;
    }

    [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
    private Mobilize.WebMap.Common.Core.Static.IStaticSlot Next_k__BackingField;
    public Mobilize.WebMap.Common.Core.Static.IStaticSlot Next
    {
        get
#line hidden
        {
            if ((_Mobilize_LoadedFlag_0 & _Mobilize_Loaded_Next) <= 0)
            {
                this.Next_k__BackingField = Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetObservable<Mobilize.WebMap.Common.Core.Static.IStaticSlot>(this, _Mobilize_References, 0);
                _Mobilize_LoadedFlag_0 |= _Mobilize_Loaded_Next;
                ;
            }

            return this.Next_k__BackingField;
        }

        set
#line hidden
        {
            if (Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.SetObservable<Mobilize.WebMap.Common.Core.Static.IStaticSlot>(this, _Mobilize_References, 0, this.Next_k__BackingField, (Mobilize.WebMap.Common.Core.Static.IStaticSlot)value))
            {
                _Mobilize_DirtyFlag_0 |= _Mobilize_Dirty_Next;
            }

            _Mobilize_LoadedFlag_0 |= _Mobilize_Loaded_Next;
            _Mobilize_ControlFlag |= _Mobilize_HasChanged_Flag;
            this.Next_k__BackingField = (Mobilize.WebMap.Common.Core.Static.IStaticSlot)value;
        }
    }

    [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
    private global::SKS.frmAbout._Mobilize_SharedState frmAbout_k__BackingField;
    internal global::SKS.frmAbout._Mobilize_SharedState frmAbout
    {
        get
#line hidden
        {
            if ((_Mobilize_LoadedFlag_0 & _Mobilize_Loaded_frmAbout) <= 0)
            {
                this.frmAbout_k__BackingField = Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetObservable<global::SKS.frmAbout._Mobilize_SharedState>(this, _Mobilize_References, 1);
                _Mobilize_LoadedFlag_0 |= _Mobilize_Loaded_frmAbout;
                if (this.frmAbout_k__BackingField == null)
                {
                    this.frmAbout = new global::SKS.frmAbout._Mobilize_SharedState();
                }
            }

            return this.frmAbout_k__BackingField;
        }

        set
#line hidden
        {
            if (Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.SetObservable<global::SKS.frmAbout._Mobilize_SharedState>(this, _Mobilize_References, 1, this.frmAbout_k__BackingField, (global::SKS.frmAbout._Mobilize_SharedState)value))
            {
                _Mobilize_DirtyFlag_0 |= _Mobilize_Dirty_frmAbout;
            }

            _Mobilize_LoadedFlag_0 |= _Mobilize_Loaded_frmAbout;
            _Mobilize_ControlFlag |= _Mobilize_HasChanged_Flag;
            this.frmAbout_k__BackingField = (global::SKS.frmAbout._Mobilize_SharedState)value;
        }
    }

    [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
    private global::SKS.frmActionOrderReception._Mobilize_SharedState frmActionOrderReception_k__BackingField;
    internal global::SKS.frmActionOrderReception._Mobilize_SharedState frmActionOrderReception
    {
        get
#line hidden
        {
            if ((_Mobilize_LoadedFlag_0 & _Mobilize_Loaded_frmActionOrderReception) <= 0)
            {
                this.frmActionOrderReception_k__BackingField = Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetObservable<global::SKS.frmActionOrderReception._Mobilize_SharedState>(this, _Mobilize_References, 2);
                _Mobilize_LoadedFlag_0 |= _Mobilize_Loaded_frmActionOrderReception;
                if (this.frmActionOrderReception_k__BackingField == null)
                {
                    this.frmActionOrderReception = new global::SKS.frmActionOrderReception._Mobilize_SharedState();
                }
            }

            return this.frmActionOrderReception_k__BackingField;
        }

        set
#line hidden
        {
            if (Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.SetObservable<global::SKS.frmActionOrderReception._Mobilize_SharedState>(this, _Mobilize_References, 2, this.frmActionOrderReception_k__BackingField, (global::SKS.frmActionOrderReception._Mobilize_SharedState)value))
            {
                _Mobilize_DirtyFlag_0 |= _Mobilize_Dirty_frmActionOrderReception;
            }

            _Mobilize_LoadedFlag_0 |= _Mobilize_Loaded_frmActionOrderReception;
            _Mobilize_ControlFlag |= _Mobilize_HasChanged_Flag;
            this.frmActionOrderReception_k__BackingField = (global::SKS.frmActionOrderReception._Mobilize_SharedState)value;
        }
    }

    [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
    private global::SKS.frmActionOrderRequest._Mobilize_SharedState frmActionOrderRequest_k__BackingField;
    internal global::SKS.frmActionOrderRequest._Mobilize_SharedState frmActionOrderRequest
    {
        get
#line hidden
        {
            if ((_Mobilize_LoadedFlag_0 & _Mobilize_Loaded_frmActionOrderRequest) <= 0)
            {
                this.frmActionOrderRequest_k__BackingField = Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetObservable<global::SKS.frmActionOrderRequest._Mobilize_SharedState>(this, _Mobilize_References, 3);
                _Mobilize_LoadedFlag_0 |= _Mobilize_Loaded_frmActionOrderRequest;
                if (this.frmActionOrderRequest_k__BackingField == null)
                {
                    this.frmActionOrderRequest = new global::SKS.frmActionOrderRequest._Mobilize_SharedState();
                }
            }

            return this.frmActionOrderRequest_k__BackingField;
        }

        set
#line hidden
        {
            if (Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.SetObservable<global::SKS.frmActionOrderRequest._Mobilize_SharedState>(this, _Mobilize_References, 3, this.frmActionOrderRequest_k__BackingField, (global::SKS.frmActionOrderRequest._Mobilize_SharedState)value))
            {
                _Mobilize_DirtyFlag_0 |= _Mobilize_Dirty_frmActionOrderRequest;
            }

            _Mobilize_LoadedFlag_0 |= _Mobilize_Loaded_frmActionOrderRequest;
            _Mobilize_ControlFlag |= _Mobilize_HasChanged_Flag;
            this.frmActionOrderRequest_k__BackingField = (global::SKS.frmActionOrderRequest._Mobilize_SharedState)value;
        }
    }

    [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
    private global::SKS.frmAddProductTo._Mobilize_SharedState frmAddProductTo_k__BackingField;
    internal global::SKS.frmAddProductTo._Mobilize_SharedState frmAddProductTo
    {
        get
#line hidden
        {
            if ((_Mobilize_LoadedFlag_0 & _Mobilize_Loaded_frmAddProductTo) <= 0)
            {
                this.frmAddProductTo_k__BackingField = Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetObservable<global::SKS.frmAddProductTo._Mobilize_SharedState>(this, _Mobilize_References, 4);
                _Mobilize_LoadedFlag_0 |= _Mobilize_Loaded_frmAddProductTo;
                if (this.frmAddProductTo_k__BackingField == null)
                {
                    this.frmAddProductTo = new global::SKS.frmAddProductTo._Mobilize_SharedState();
                }
            }

            return this.frmAddProductTo_k__BackingField;
        }

        set
#line hidden
        {
            if (Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.SetObservable<global::SKS.frmAddProductTo._Mobilize_SharedState>(this, _Mobilize_References, 4, this.frmAddProductTo_k__BackingField, (global::SKS.frmAddProductTo._Mobilize_SharedState)value))
            {
                _Mobilize_DirtyFlag_0 |= _Mobilize_Dirty_frmAddProductTo;
            }

            _Mobilize_LoadedFlag_0 |= _Mobilize_Loaded_frmAddProductTo;
            _Mobilize_ControlFlag |= _Mobilize_HasChanged_Flag;
            this.frmAddProductTo_k__BackingField = (global::SKS.frmAddProductTo._Mobilize_SharedState)value;
        }
    }

    [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
    private global::SKS.frmAddStockManual._Mobilize_SharedState frmAddStockManual_k__BackingField;
    internal global::SKS.frmAddStockManual._Mobilize_SharedState frmAddStockManual
    {
        get
#line hidden
        {
            if ((_Mobilize_LoadedFlag_0 & _Mobilize_Loaded_frmAddStockManual) <= 0)
            {
                this.frmAddStockManual_k__BackingField = Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetObservable<global::SKS.frmAddStockManual._Mobilize_SharedState>(this, _Mobilize_References, 5);
                _Mobilize_LoadedFlag_0 |= _Mobilize_Loaded_frmAddStockManual;
                if (this.frmAddStockManual_k__BackingField == null)
                {
                    this.frmAddStockManual = new global::SKS.frmAddStockManual._Mobilize_SharedState();
                }
            }

            return this.frmAddStockManual_k__BackingField;
        }

        set
#line hidden
        {
            if (Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.SetObservable<global::SKS.frmAddStockManual._Mobilize_SharedState>(this, _Mobilize_References, 5, this.frmAddStockManual_k__BackingField, (global::SKS.frmAddStockManual._Mobilize_SharedState)value))
            {
                _Mobilize_DirtyFlag_0 |= _Mobilize_Dirty_frmAddStockManual;
            }

            _Mobilize_LoadedFlag_0 |= _Mobilize_Loaded_frmAddStockManual;
            _Mobilize_ControlFlag |= _Mobilize_HasChanged_Flag;
            this.frmAddStockManual_k__BackingField = (global::SKS.frmAddStockManual._Mobilize_SharedState)value;
        }
    }

    [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
    private global::SKS.frmAdjustStockManual._Mobilize_SharedState frmAdjustStockManual_k__BackingField;
    internal global::SKS.frmAdjustStockManual._Mobilize_SharedState frmAdjustStockManual
    {
        get
#line hidden
        {
            if ((_Mobilize_LoadedFlag_0 & _Mobilize_Loaded_frmAdjustStockManual) <= 0)
            {
                this.frmAdjustStockManual_k__BackingField = Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetObservable<global::SKS.frmAdjustStockManual._Mobilize_SharedState>(this, _Mobilize_References, 6);
                _Mobilize_LoadedFlag_0 |= _Mobilize_Loaded_frmAdjustStockManual;
                if (this.frmAdjustStockManual_k__BackingField == null)
                {
                    this.frmAdjustStockManual = new global::SKS.frmAdjustStockManual._Mobilize_SharedState();
                }
            }

            return this.frmAdjustStockManual_k__BackingField;
        }

        set
#line hidden
        {
            if (Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.SetObservable<global::SKS.frmAdjustStockManual._Mobilize_SharedState>(this, _Mobilize_References, 6, this.frmAdjustStockManual_k__BackingField, (global::SKS.frmAdjustStockManual._Mobilize_SharedState)value))
            {
                _Mobilize_DirtyFlag_0 |= _Mobilize_Dirty_frmAdjustStockManual;
            }

            _Mobilize_LoadedFlag_0 |= _Mobilize_Loaded_frmAdjustStockManual;
            _Mobilize_ControlFlag |= _Mobilize_HasChanged_Flag;
            this.frmAdjustStockManual_k__BackingField = (global::SKS.frmAdjustStockManual._Mobilize_SharedState)value;
        }
    }

    [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
    private global::SKS.frmCustomers._Mobilize_SharedState frmCustomers_k__BackingField;
    internal global::SKS.frmCustomers._Mobilize_SharedState frmCustomers
    {
        get
#line hidden
        {
            if ((_Mobilize_LoadedFlag_0 & _Mobilize_Loaded_frmCustomers) <= 0)
            {
                this.frmCustomers_k__BackingField = Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetObservable<global::SKS.frmCustomers._Mobilize_SharedState>(this, _Mobilize_References, 7);
                _Mobilize_LoadedFlag_0 |= _Mobilize_Loaded_frmCustomers;
                if (this.frmCustomers_k__BackingField == null)
                {
                    this.frmCustomers = new global::SKS.frmCustomers._Mobilize_SharedState();
                }
            }

            return this.frmCustomers_k__BackingField;
        }

        set
#line hidden
        {
            if (Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.SetObservable<global::SKS.frmCustomers._Mobilize_SharedState>(this, _Mobilize_References, 7, this.frmCustomers_k__BackingField, (global::SKS.frmCustomers._Mobilize_SharedState)value))
            {
                _Mobilize_DirtyFlag_0 |= _Mobilize_Dirty_frmCustomers;
            }

            _Mobilize_LoadedFlag_0 |= _Mobilize_Loaded_frmCustomers;
            _Mobilize_ControlFlag |= _Mobilize_HasChanged_Flag;
            this.frmCustomers_k__BackingField = (global::SKS.frmCustomers._Mobilize_SharedState)value;
        }
    }

    [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
    private global::SKS.frmLogin._Mobilize_SharedState frmLogin_k__BackingField;
    internal global::SKS.frmLogin._Mobilize_SharedState frmLogin
    {
        get
#line hidden
        {
            if ((_Mobilize_LoadedFlag_0 & _Mobilize_Loaded_frmLogin) <= 0)
            {
                this.frmLogin_k__BackingField = Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetObservable<global::SKS.frmLogin._Mobilize_SharedState>(this, _Mobilize_References, 8);
                _Mobilize_LoadedFlag_0 |= _Mobilize_Loaded_frmLogin;
                if (this.frmLogin_k__BackingField == null)
                {
                    this.frmLogin = new global::SKS.frmLogin._Mobilize_SharedState();
                }
            }

            return this.frmLogin_k__BackingField;
        }

        set
#line hidden
        {
            if (Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.SetObservable<global::SKS.frmLogin._Mobilize_SharedState>(this, _Mobilize_References, 8, this.frmLogin_k__BackingField, (global::SKS.frmLogin._Mobilize_SharedState)value))
            {
                _Mobilize_DirtyFlag_0 |= _Mobilize_Dirty_frmLogin;
            }

            _Mobilize_LoadedFlag_0 |= _Mobilize_Loaded_frmLogin;
            _Mobilize_ControlFlag |= _Mobilize_HasChanged_Flag;
            this.frmLogin_k__BackingField = (global::SKS.frmLogin._Mobilize_SharedState)value;
        }
    }

    [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
    private global::SKS.frmMain._Mobilize_SharedState frmMain_k__BackingField;
    internal global::SKS.frmMain._Mobilize_SharedState frmMain
    {
        get
#line hidden
        {
            if ((_Mobilize_LoadedFlag_0 & _Mobilize_Loaded_frmMain) <= 0)
            {
                this.frmMain_k__BackingField = Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetObservable<global::SKS.frmMain._Mobilize_SharedState>(this, _Mobilize_References, 9);
                _Mobilize_LoadedFlag_0 |= _Mobilize_Loaded_frmMain;
                if (this.frmMain_k__BackingField == null)
                {
                    this.frmMain = new global::SKS.frmMain._Mobilize_SharedState();
                }
            }

            return this.frmMain_k__BackingField;
        }

        set
#line hidden
        {
            if (Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.SetObservable<global::SKS.frmMain._Mobilize_SharedState>(this, _Mobilize_References, 9, this.frmMain_k__BackingField, (global::SKS.frmMain._Mobilize_SharedState)value))
            {
                _Mobilize_DirtyFlag_0 |= _Mobilize_Dirty_frmMain;
            }

            _Mobilize_LoadedFlag_0 |= _Mobilize_Loaded_frmMain;
            _Mobilize_ControlFlag |= _Mobilize_HasChanged_Flag;
            this.frmMain_k__BackingField = (global::SKS.frmMain._Mobilize_SharedState)value;
        }
    }

    [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
    private global::SKS.frmReceptionApproval._Mobilize_SharedState frmReceptionApproval_k__BackingField;
    internal global::SKS.frmReceptionApproval._Mobilize_SharedState frmReceptionApproval
    {
        get
#line hidden
        {
            if ((_Mobilize_LoadedFlag_0 & _Mobilize_Loaded_frmReceptionApproval) <= 0)
            {
                this.frmReceptionApproval_k__BackingField = Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetObservable<global::SKS.frmReceptionApproval._Mobilize_SharedState>(this, _Mobilize_References, 10);
                _Mobilize_LoadedFlag_0 |= _Mobilize_Loaded_frmReceptionApproval;
                if (this.frmReceptionApproval_k__BackingField == null)
                {
                    this.frmReceptionApproval = new global::SKS.frmReceptionApproval._Mobilize_SharedState();
                }
            }

            return this.frmReceptionApproval_k__BackingField;
        }

        set
#line hidden
        {
            if (Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.SetObservable<global::SKS.frmReceptionApproval._Mobilize_SharedState>(this, _Mobilize_References, 10, this.frmReceptionApproval_k__BackingField, (global::SKS.frmReceptionApproval._Mobilize_SharedState)value))
            {
                _Mobilize_DirtyFlag_0 |= _Mobilize_Dirty_frmReceptionApproval;
            }

            _Mobilize_LoadedFlag_0 |= _Mobilize_Loaded_frmReceptionApproval;
            _Mobilize_ControlFlag |= _Mobilize_HasChanged_Flag;
            this.frmReceptionApproval_k__BackingField = (global::SKS.frmReceptionApproval._Mobilize_SharedState)value;
        }
    }

    [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
    private global::SKS.frmOrderReception._Mobilize_SharedState frmOrderReception_k__BackingField;
    internal global::SKS.frmOrderReception._Mobilize_SharedState frmOrderReception
    {
        get
#line hidden
        {
            if ((_Mobilize_LoadedFlag_0 & _Mobilize_Loaded_frmOrderReception) <= 0)
            {
                this.frmOrderReception_k__BackingField = Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetObservable<global::SKS.frmOrderReception._Mobilize_SharedState>(this, _Mobilize_References, 11);
                _Mobilize_LoadedFlag_0 |= _Mobilize_Loaded_frmOrderReception;
                if (this.frmOrderReception_k__BackingField == null)
                {
                    this.frmOrderReception = new global::SKS.frmOrderReception._Mobilize_SharedState();
                }
            }

            return this.frmOrderReception_k__BackingField;
        }

        set
#line hidden
        {
            if (Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.SetObservable<global::SKS.frmOrderReception._Mobilize_SharedState>(this, _Mobilize_References, 11, this.frmOrderReception_k__BackingField, (global::SKS.frmOrderReception._Mobilize_SharedState)value))
            {
                _Mobilize_DirtyFlag_0 |= _Mobilize_Dirty_frmOrderReception;
            }

            _Mobilize_LoadedFlag_0 |= _Mobilize_Loaded_frmOrderReception;
            _Mobilize_ControlFlag |= _Mobilize_HasChanged_Flag;
            this.frmOrderReception_k__BackingField = (global::SKS.frmOrderReception._Mobilize_SharedState)value;
        }
    }

    [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
    private global::SKS.frmOrderRequest._Mobilize_SharedState frmOrderRequest_k__BackingField;
    internal global::SKS.frmOrderRequest._Mobilize_SharedState frmOrderRequest
    {
        get
#line hidden
        {
            if ((_Mobilize_LoadedFlag_0 & _Mobilize_Loaded_frmOrderRequest) <= 0)
            {
                this.frmOrderRequest_k__BackingField = Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetObservable<global::SKS.frmOrderRequest._Mobilize_SharedState>(this, _Mobilize_References, 12);
                _Mobilize_LoadedFlag_0 |= _Mobilize_Loaded_frmOrderRequest;
                if (this.frmOrderRequest_k__BackingField == null)
                {
                    this.frmOrderRequest = new global::SKS.frmOrderRequest._Mobilize_SharedState();
                }
            }

            return this.frmOrderRequest_k__BackingField;
        }

        set
#line hidden
        {
            if (Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.SetObservable<global::SKS.frmOrderRequest._Mobilize_SharedState>(this, _Mobilize_References, 12, this.frmOrderRequest_k__BackingField, (global::SKS.frmOrderRequest._Mobilize_SharedState)value))
            {
                _Mobilize_DirtyFlag_0 |= _Mobilize_Dirty_frmOrderRequest;
            }

            _Mobilize_LoadedFlag_0 |= _Mobilize_Loaded_frmOrderRequest;
            _Mobilize_ControlFlag |= _Mobilize_HasChanged_Flag;
            this.frmOrderRequest_k__BackingField = (global::SKS.frmOrderRequest._Mobilize_SharedState)value;
        }
    }

    [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
    private global::SKS.frmProducts._Mobilize_SharedState frmProducts_k__BackingField;
    internal global::SKS.frmProducts._Mobilize_SharedState frmProducts
    {
        get
#line hidden
        {
            if ((_Mobilize_LoadedFlag_0 & _Mobilize_Loaded_frmProducts) <= 0)
            {
                this.frmProducts_k__BackingField = Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetObservable<global::SKS.frmProducts._Mobilize_SharedState>(this, _Mobilize_References, 13);
                _Mobilize_LoadedFlag_0 |= _Mobilize_Loaded_frmProducts;
                if (this.frmProducts_k__BackingField == null)
                {
                    this.frmProducts = new global::SKS.frmProducts._Mobilize_SharedState();
                }
            }

            return this.frmProducts_k__BackingField;
        }

        set
#line hidden
        {
            if (Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.SetObservable<global::SKS.frmProducts._Mobilize_SharedState>(this, _Mobilize_References, 13, this.frmProducts_k__BackingField, (global::SKS.frmProducts._Mobilize_SharedState)value))
            {
                _Mobilize_DirtyFlag_0 |= _Mobilize_Dirty_frmProducts;
            }

            _Mobilize_LoadedFlag_0 |= _Mobilize_Loaded_frmProducts;
            _Mobilize_ControlFlag |= _Mobilize_HasChanged_Flag;
            this.frmProducts_k__BackingField = (global::SKS.frmProducts._Mobilize_SharedState)value;
        }
    }

    [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
    private global::SKS.frmProviders._Mobilize_SharedState frmProviders_k__BackingField;
    internal global::SKS.frmProviders._Mobilize_SharedState frmProviders
    {
        get
#line hidden
        {
            if ((_Mobilize_LoadedFlag_0 & _Mobilize_Loaded_frmProviders) <= 0)
            {
                this.frmProviders_k__BackingField = Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetObservable<global::SKS.frmProviders._Mobilize_SharedState>(this, _Mobilize_References, 14);
                _Mobilize_LoadedFlag_0 |= _Mobilize_Loaded_frmProviders;
                if (this.frmProviders_k__BackingField == null)
                {
                    this.frmProviders = new global::SKS.frmProviders._Mobilize_SharedState();
                }
            }

            return this.frmProviders_k__BackingField;
        }

        set
#line hidden
        {
            if (Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.SetObservable<global::SKS.frmProviders._Mobilize_SharedState>(this, _Mobilize_References, 14, this.frmProviders_k__BackingField, (global::SKS.frmProviders._Mobilize_SharedState)value))
            {
                _Mobilize_DirtyFlag_0 |= _Mobilize_Dirty_frmProviders;
            }

            _Mobilize_LoadedFlag_0 |= _Mobilize_Loaded_frmProviders;
            _Mobilize_ControlFlag |= _Mobilize_HasChanged_Flag;
            this.frmProviders_k__BackingField = (global::SKS.frmProviders._Mobilize_SharedState)value;
        }
    }

    [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
    private global::SKS.frmRequestApproval._Mobilize_SharedState frmRequestApproval_k__BackingField;
    internal global::SKS.frmRequestApproval._Mobilize_SharedState frmRequestApproval
    {
        get
#line hidden
        {
            if ((_Mobilize_LoadedFlag_0 & _Mobilize_Loaded_frmRequestApproval) <= 0)
            {
                this.frmRequestApproval_k__BackingField = Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetObservable<global::SKS.frmRequestApproval._Mobilize_SharedState>(this, _Mobilize_References, 15);
                _Mobilize_LoadedFlag_0 |= _Mobilize_Loaded_frmRequestApproval;
                if (this.frmRequestApproval_k__BackingField == null)
                {
                    this.frmRequestApproval = new global::SKS.frmRequestApproval._Mobilize_SharedState();
                }
            }

            return this.frmRequestApproval_k__BackingField;
        }

        set
#line hidden
        {
            if (Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.SetObservable<global::SKS.frmRequestApproval._Mobilize_SharedState>(this, _Mobilize_References, 15, this.frmRequestApproval_k__BackingField, (global::SKS.frmRequestApproval._Mobilize_SharedState)value))
            {
                _Mobilize_DirtyFlag_0 |= _Mobilize_Dirty_frmRequestApproval;
            }

            _Mobilize_LoadedFlag_0 |= _Mobilize_Loaded_frmRequestApproval;
            _Mobilize_ControlFlag |= _Mobilize_HasChanged_Flag;
            this.frmRequestApproval_k__BackingField = (global::SKS.frmRequestApproval._Mobilize_SharedState)value;
        }
    }

    [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
    private global::SKS.frmSearch._Mobilize_SharedState frmSearch_k__BackingField;
    internal global::SKS.frmSearch._Mobilize_SharedState frmSearch
    {
        get
#line hidden
        {
            if ((_Mobilize_LoadedFlag_0 & _Mobilize_Loaded_frmSearch) <= 0)
            {
                this.frmSearch_k__BackingField = Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetObservable<global::SKS.frmSearch._Mobilize_SharedState>(this, _Mobilize_References, 16);
                _Mobilize_LoadedFlag_0 |= _Mobilize_Loaded_frmSearch;
                if (this.frmSearch_k__BackingField == null)
                {
                    this.frmSearch = new global::SKS.frmSearch._Mobilize_SharedState();
                }
            }

            return this.frmSearch_k__BackingField;
        }

        set
#line hidden
        {
            if (Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.SetObservable<global::SKS.frmSearch._Mobilize_SharedState>(this, _Mobilize_References, 16, this.frmSearch_k__BackingField, (global::SKS.frmSearch._Mobilize_SharedState)value))
            {
                _Mobilize_DirtyFlag_0 |= _Mobilize_Dirty_frmSearch;
            }

            _Mobilize_LoadedFlag_0 |= _Mobilize_Loaded_frmSearch;
            _Mobilize_ControlFlag |= _Mobilize_HasChanged_Flag;
            this.frmSearch_k__BackingField = (global::SKS.frmSearch._Mobilize_SharedState)value;
        }
    }

    [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
    private global::SKS.frmSplash._Mobilize_SharedState frmSplash_k__BackingField;
    internal global::SKS.frmSplash._Mobilize_SharedState frmSplash
    {
        get
#line hidden
        {
            if ((_Mobilize_LoadedFlag_0 & _Mobilize_Loaded_frmSplash) <= 0)
            {
                this.frmSplash_k__BackingField = Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetObservable<global::SKS.frmSplash._Mobilize_SharedState>(this, _Mobilize_References, 17);
                _Mobilize_LoadedFlag_0 |= _Mobilize_Loaded_frmSplash;
                if (this.frmSplash_k__BackingField == null)
                {
                    this.frmSplash = new global::SKS.frmSplash._Mobilize_SharedState();
                }
            }

            return this.frmSplash_k__BackingField;
        }

        set
#line hidden
        {
            if (Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.SetObservable<global::SKS.frmSplash._Mobilize_SharedState>(this, _Mobilize_References, 17, this.frmSplash_k__BackingField, (global::SKS.frmSplash._Mobilize_SharedState)value))
            {
                _Mobilize_DirtyFlag_0 |= _Mobilize_Dirty_frmSplash;
            }

            _Mobilize_LoadedFlag_0 |= _Mobilize_Loaded_frmSplash;
            _Mobilize_ControlFlag |= _Mobilize_HasChanged_Flag;
            this.frmSplash_k__BackingField = (global::SKS.frmSplash._Mobilize_SharedState)value;
        }
    }

    [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
    private global::SKS.frmUsersManage._Mobilize_SharedState frmUsersManage_k__BackingField;
    internal global::SKS.frmUsersManage._Mobilize_SharedState frmUsersManage
    {
        get
#line hidden
        {
            if ((_Mobilize_LoadedFlag_0 & _Mobilize_Loaded_frmUsersManage) <= 0)
            {
                this.frmUsersManage_k__BackingField = Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetObservable<global::SKS.frmUsersManage._Mobilize_SharedState>(this, _Mobilize_References, 18);
                _Mobilize_LoadedFlag_0 |= _Mobilize_Loaded_frmUsersManage;
                if (this.frmUsersManage_k__BackingField == null)
                {
                    this.frmUsersManage = new global::SKS.frmUsersManage._Mobilize_SharedState();
                }
            }

            return this.frmUsersManage_k__BackingField;
        }

        set
#line hidden
        {
            if (Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.SetObservable<global::SKS.frmUsersManage._Mobilize_SharedState>(this, _Mobilize_References, 18, this.frmUsersManage_k__BackingField, (global::SKS.frmUsersManage._Mobilize_SharedState)value))
            {
                _Mobilize_DirtyFlag_0 |= _Mobilize_Dirty_frmUsersManage;
            }

            _Mobilize_LoadedFlag_0 |= _Mobilize_Loaded_frmUsersManage;
            _Mobilize_ControlFlag |= _Mobilize_HasChanged_Flag;
            this.frmUsersManage_k__BackingField = (global::SKS.frmUsersManage._Mobilize_SharedState)value;
        }
    }

    [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
    private global::SKS.modConnection._Mobilize_SharedState modConnection_k__BackingField;
    internal global::SKS.modConnection._Mobilize_SharedState modConnection
    {
        get
#line hidden
        {
            if ((_Mobilize_LoadedFlag_0 & _Mobilize_Loaded_modConnection) <= 0)
            {
                this.modConnection_k__BackingField = Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetObservable<global::SKS.modConnection._Mobilize_SharedState>(this, _Mobilize_References, 19);
                _Mobilize_LoadedFlag_0 |= _Mobilize_Loaded_modConnection;
                if (this.modConnection_k__BackingField == null)
                {
                    this.modConnection = new global::SKS.modConnection._Mobilize_SharedState();
                }
            }

            return this.modConnection_k__BackingField;
        }

        set
#line hidden
        {
            if (Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.SetObservable<global::SKS.modConnection._Mobilize_SharedState>(this, _Mobilize_References, 19, this.modConnection_k__BackingField, (global::SKS.modConnection._Mobilize_SharedState)value))
            {
                _Mobilize_DirtyFlag_0 |= _Mobilize_Dirty_modConnection;
            }

            _Mobilize_LoadedFlag_0 |= _Mobilize_Loaded_modConnection;
            _Mobilize_ControlFlag |= _Mobilize_HasChanged_Flag;
            this.modConnection_k__BackingField = (global::SKS.modConnection._Mobilize_SharedState)value;
        }
    }

    [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
    private global::SKS.modMain._Mobilize_SharedState modMain_k__BackingField;
    internal global::SKS.modMain._Mobilize_SharedState modMain
    {
        get
#line hidden
        {
            if ((_Mobilize_LoadedFlag_0 & _Mobilize_Loaded_modMain) <= 0)
            {
                this.modMain_k__BackingField = Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetObservable<global::SKS.modMain._Mobilize_SharedState>(this, _Mobilize_References, 20);
                _Mobilize_LoadedFlag_0 |= _Mobilize_Loaded_modMain;
                if (this.modMain_k__BackingField == null)
                {
                    this.modMain = new global::SKS.modMain._Mobilize_SharedState();
                }
            }

            return this.modMain_k__BackingField;
        }

        set
#line hidden
        {
            if (Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.SetObservable<global::SKS.modMain._Mobilize_SharedState>(this, _Mobilize_References, 20, this.modMain_k__BackingField, (global::SKS.modMain._Mobilize_SharedState)value))
            {
                _Mobilize_DirtyFlag_0 |= _Mobilize_Dirty_modMain;
            }

            _Mobilize_LoadedFlag_0 |= _Mobilize_Loaded_modMain;
            _Mobilize_ControlFlag |= _Mobilize_HasChanged_Flag;
            this.modMain_k__BackingField = (global::SKS.modMain._Mobilize_SharedState)value;
        }
    }
}
//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 4.0.2
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------

namespace NWN.Native.API {

public unsafe class CNWSPlayerContainerGUI : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  public CNWSPlayerContainerGUI(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  public CNWSPlayerContainerGUI(void* cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, (global::System.IntPtr)cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CNWSPlayerContainerGUI obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~CNWSPlayerContainerGUI() {
    Dispose(false);
  }

  public void Dispose() {
    Dispose(true);
    global::System.GC.SuppressFinalize(this);
  }

  protected virtual void Dispose(bool disposing) {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          NWNXLibPINVOKE.delete_CNWSPlayerContainerGUI(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
    }
  }

  public System.IntPtr Pointer {
    get {
      return swigCPtr.Handle;
    }
  }

  public static unsafe implicit operator void*(CNWSPlayerContainerGUI self) {
    return (void*)self.swigCPtr.Handle;
  }

  public static implicit operator System.IntPtr(CNWSPlayerContainerGUI self) {
    return self.swigCPtr.Handle;
  }

  public bool Equals(CNWSPlayerContainerGUI other) {
    if (ReferenceEquals(null, other)) {
      return false;
    }

    if (ReferenceEquals(this, other)) {
      return true;
    }

    return Pointer.Equals(other.Pointer);
  }

  public override bool Equals(object obj) {
    return ReferenceEquals(this, obj) || obj is CNWSPlayerContainerGUI other && Equals(other);
  }

  public override int GetHashCode() {
    return swigCPtr.Handle.GetHashCode();
  }

  public static bool operator ==(CNWSPlayerContainerGUI left, CNWSPlayerContainerGUI right) {
    return Equals(left, right);
  }

  public static bool operator !=(CNWSPlayerContainerGUI left, CNWSPlayerContainerGUI right) {
    return !Equals(left, right);
  }

  public uint m_oidOpen {
    set {
      NWNXLibPINVOKE.CNWSPlayerContainerGUI_m_oidOpen_set(swigCPtr, value);
    } 
    get {
      uint ret = NWNXLibPINVOKE.CNWSPlayerContainerGUI_m_oidOpen_get(swigCPtr);
      return ret;
    } 
  }

  public int m_bOpenedTheInventory {
    set {
      NWNXLibPINVOKE.CNWSPlayerContainerGUI_m_bOpenedTheInventory_set(swigCPtr, value);
    } 
    get {
      int ret = NWNXLibPINVOKE.CNWSPlayerContainerGUI_m_bOpenedTheInventory_get(swigCPtr);
      return ret;
    } 
  }

  public byte m_nSelectedPanel {
    set {
      NWNXLibPINVOKE.CNWSPlayerContainerGUI_m_nSelectedPanel_set(swigCPtr, value);
    } 
    get {
      byte ret = NWNXLibPINVOKE.CNWSPlayerContainerGUI_m_nSelectedPanel_get(swigCPtr);
      return ret;
    } 
  }

  public CNWSPlayerContainerGUI() : this(NWNXLibPINVOKE.new_CNWSPlayerContainerGUI(), true) {
  }

  public void SetOpen(CNWSPlayer pPlayer, uint oidItem, int bContainerOpenedTheInventory) {
    NWNXLibPINVOKE.CNWSPlayerContainerGUI_SetOpen__SWIG_0(swigCPtr, CNWSPlayer.getCPtr(pPlayer), oidItem, bContainerOpenedTheInventory);
  }

  public void SetOpen(CNWSPlayer pPlayer, uint oidItem) {
    NWNXLibPINVOKE.CNWSPlayerContainerGUI_SetOpen__SWIG_1(swigCPtr, CNWSPlayer.getCPtr(pPlayer), oidItem);
  }

  public void SetNextPage(CNWSPlayer pPlayer) {
    NWNXLibPINVOKE.CNWSPlayerContainerGUI_SetNextPage(swigCPtr, CNWSPlayer.getCPtr(pPlayer));
  }

  public void SetPreviousPage(CNWSPlayer pPlayer) {
    NWNXLibPINVOKE.CNWSPlayerContainerGUI_SetPreviousPage(swigCPtr, CNWSPlayer.getCPtr(pPlayer));
  }

}

}

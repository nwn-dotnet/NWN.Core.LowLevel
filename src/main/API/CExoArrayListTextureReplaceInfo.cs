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

public unsafe class CExoArrayListTextureReplaceInfo : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  public CExoArrayListTextureReplaceInfo(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  public CExoArrayListTextureReplaceInfo(void* cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, (global::System.IntPtr)cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CExoArrayListTextureReplaceInfo obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~CExoArrayListTextureReplaceInfo() {
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
          NWNXLibPINVOKE.delete_CExoArrayListTextureReplaceInfo(swigCPtr);
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

  public static unsafe implicit operator void*(CExoArrayListTextureReplaceInfo self) {
    return (void*)self.swigCPtr.Handle;
  }

  public static implicit operator System.IntPtr(CExoArrayListTextureReplaceInfo self) {
    return self.swigCPtr.Handle;
  }

  public bool Equals(CExoArrayListTextureReplaceInfo other) {
    if (ReferenceEquals(null, other)) {
      return false;
    }

    if (ReferenceEquals(this, other)) {
      return true;
    }

    return Pointer.Equals(other.Pointer);
  }

  public override bool Equals(object obj) {
    return ReferenceEquals(this, obj) || obj is CExoArrayListTextureReplaceInfo other && Equals(other);
  }

  public override int GetHashCode() {
    return swigCPtr.Handle.GetHashCode();
  }

  public static bool operator ==(CExoArrayListTextureReplaceInfo left, CExoArrayListTextureReplaceInfo right) {
    return Equals(left, right);
  }

  public static bool operator !=(CExoArrayListTextureReplaceInfo left, CExoArrayListTextureReplaceInfo right) {
    return !Equals(left, right);
  }

  public TextureReplaceInfo element {
    set {
      NWNXLibPINVOKE.CExoArrayListTextureReplaceInfo_element_set(swigCPtr, TextureReplaceInfo.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CExoArrayListTextureReplaceInfo_element_get(swigCPtr);
      TextureReplaceInfo ret = (cPtr == global::System.IntPtr.Zero) ? null : new TextureReplaceInfo(cPtr, false);
      return ret;
    } 
  }

  public int num {
    set {
      NWNXLibPINVOKE.CExoArrayListTextureReplaceInfo_num_set(swigCPtr, value);
    } 
    get {
      int ret = NWNXLibPINVOKE.CExoArrayListTextureReplaceInfo_num_get(swigCPtr);
      return ret;
    } 
  }

  public int array_size {
    set {
      NWNXLibPINVOKE.CExoArrayListTextureReplaceInfo_array_size_set(swigCPtr, value);
    } 
    get {
      int ret = NWNXLibPINVOKE.CExoArrayListTextureReplaceInfo_array_size_get(swigCPtr);
      return ret;
    } 
  }

  public CExoArrayListTextureReplaceInfo(int s) : this(NWNXLibPINVOKE.new_CExoArrayListTextureReplaceInfo__SWIG_0(s), true) {
  }

  public CExoArrayListTextureReplaceInfo() : this(NWNXLibPINVOKE.new_CExoArrayListTextureReplaceInfo__SWIG_1(), true) {
  }

  public CExoArrayListTextureReplaceInfo(CExoArrayListTextureReplaceInfo list) : this(NWNXLibPINVOKE.new_CExoArrayListTextureReplaceInfo__SWIG_2(CExoArrayListTextureReplaceInfo.getCPtr(list)), true) {
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
  }

  public CExoArrayListTextureReplaceInfo _OpAssign(CExoArrayListTextureReplaceInfo list) {
    CExoArrayListTextureReplaceInfo ret = new CExoArrayListTextureReplaceInfo(NWNXLibPINVOKE.CExoArrayListTextureReplaceInfo__OpAssign(swigCPtr, CExoArrayListTextureReplaceInfo.getCPtr(list)), false);
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public TextureReplaceInfo _OpIndex(int i) {
    TextureReplaceInfo ret = new TextureReplaceInfo(NWNXLibPINVOKE.CExoArrayListTextureReplaceInfo__OpIndex(swigCPtr, i), false);
    return ret;
  }

  public void Allocate(int s) {
    NWNXLibPINVOKE.CExoArrayListTextureReplaceInfo_Allocate(swigCPtr, s);
  }

  public void SetSize(int s) {
    NWNXLibPINVOKE.CExoArrayListTextureReplaceInfo_SetSize(swigCPtr, s);
  }

  public void Pack() {
    NWNXLibPINVOKE.CExoArrayListTextureReplaceInfo_Pack(swigCPtr);
  }

  public void Add(TextureReplaceInfo t) {
    NWNXLibPINVOKE.CExoArrayListTextureReplaceInfo_Add(swigCPtr, TextureReplaceInfo.getCPtr(t));
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
  }

  public void Insert(TextureReplaceInfo t, int k) {
    NWNXLibPINVOKE.CExoArrayListTextureReplaceInfo_Insert(swigCPtr, TextureReplaceInfo.getCPtr(t), k);
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
  }

  public void DelIndex(int i) {
    NWNXLibPINVOKE.CExoArrayListTextureReplaceInfo_DelIndex(swigCPtr, i);
  }

  public TextureReplaceInfo begin() {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CExoArrayListTextureReplaceInfo_begin(swigCPtr);
    TextureReplaceInfo ret = (cPtr == global::System.IntPtr.Zero) ? null : new TextureReplaceInfo(cPtr, false);
    return ret;
  }

  public TextureReplaceInfo end() {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CExoArrayListTextureReplaceInfo_end(swigCPtr);
    TextureReplaceInfo ret = (cPtr == global::System.IntPtr.Zero) ? null : new TextureReplaceInfo(cPtr, false);
    return ret;
  }

}

}

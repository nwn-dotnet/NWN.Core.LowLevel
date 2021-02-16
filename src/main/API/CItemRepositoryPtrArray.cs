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

public unsafe class CItemRepositoryPtrArray : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  public CItemRepositoryPtrArray(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  public CItemRepositoryPtrArray(void* cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, (global::System.IntPtr)cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CItemRepositoryPtrArray obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~CItemRepositoryPtrArray() {
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
          NWNXLibPINVOKE.delete_CItemRepositoryPtrArray(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
    }
  }

  public CItemRepository this[int index] {
    get {
      return GetItem(index);
    }
    set {
      SetItem(index, value);
    }
  }

  public System.IntPtr Pointer {
    get {
      return swigCPtr.Handle;
    }
  }

  public static implicit operator void*(CItemRepositoryPtrArray self) {
    return (void*)self.swigCPtr.Handle;
  }

  public static implicit operator System.IntPtr(CItemRepositoryPtrArray self) {
    return self.swigCPtr.Handle;
  }

  public bool Equals(CItemRepositoryPtrArray other) {
    if (ReferenceEquals(null, other)) {
      return false;
    }

    if (ReferenceEquals(this, other)) {
      return true;
    }

    return Pointer.Equals(other.Pointer);
  }

  public override bool Equals(object obj) {
    return ReferenceEquals(this, obj) || obj is CItemRepositoryPtrArray other && Equals(other);
  }

  public override int GetHashCode() {
    return swigCPtr.Handle.GetHashCode();
  }

  public static bool operator ==(CItemRepositoryPtrArray left, CItemRepositoryPtrArray right) {
    return Equals(left, right);
  }

  public static bool operator !=(CItemRepositoryPtrArray left, CItemRepositoryPtrArray right) {
    return !Equals(left, right);
  }

  public CItemRepositoryPtrArray(int nElements) : this(NWNXLibPINVOKE.new_CItemRepositoryPtrArray(nElements), true) {
  }

  public CItemRepository GetItem(int index) {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CItemRepositoryPtrArray_GetItem(swigCPtr, index);
    CItemRepository ret = (cPtr == global::System.IntPtr.Zero) ? null : new CItemRepository(cPtr, false);
    return ret;
  }

  public void SetItem(int index, CItemRepository value) {
    NWNXLibPINVOKE.CItemRepositoryPtrArray_SetItem(swigCPtr, index, CItemRepository.getCPtr(value));
  }

  public static CItemRepositoryPtrArray FromPointer(System.IntPtr* ptr) {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CItemRepositoryPtrArray_FromPointer((global::System.IntPtr)ptr);
    CItemRepositoryPtrArray ret = (cPtr == global::System.IntPtr.Zero) ? null : new CItemRepositoryPtrArray(cPtr, false);
    return ret;
  }

}

}

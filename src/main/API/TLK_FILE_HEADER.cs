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

public unsafe class TLK_FILE_HEADER : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  public TLK_FILE_HEADER(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  public TLK_FILE_HEADER(void* cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, (global::System.IntPtr)cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(TLK_FILE_HEADER obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~TLK_FILE_HEADER() {
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
          NWNXLibPINVOKE.delete_TLK_FILE_HEADER(swigCPtr);
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

  public static unsafe implicit operator void*(TLK_FILE_HEADER self) {
    return (void*)self.swigCPtr.Handle;
  }

  public static implicit operator System.IntPtr(TLK_FILE_HEADER self) {
    return self.swigCPtr.Handle;
  }

  public bool Equals(TLK_FILE_HEADER other) {
    if (ReferenceEquals(null, other)) {
      return false;
    }

    if (ReferenceEquals(this, other)) {
      return true;
    }

    return Pointer.Equals(other.Pointer);
  }

  public override bool Equals(object obj) {
    return ReferenceEquals(this, obj) || obj is TLK_FILE_HEADER other && Equals(other);
  }

  public override int GetHashCode() {
    return swigCPtr.Handle.GetHashCode();
  }

  public static bool operator ==(TLK_FILE_HEADER left, TLK_FILE_HEADER right) {
    return Equals(left, right);
  }

  public static bool operator !=(TLK_FILE_HEADER left, TLK_FILE_HEADER right) {
    return !Equals(left, right);
  }

  public uint fileType {
    set {
      NWNXLibPINVOKE.TLK_FILE_HEADER_fileType_set(swigCPtr, value);
    } 
    get {
      uint ret = NWNXLibPINVOKE.TLK_FILE_HEADER_fileType_get(swigCPtr);
      return ret;
    } 
  }

  public uint versionNum {
    set {
      NWNXLibPINVOKE.TLK_FILE_HEADER_versionNum_set(swigCPtr, value);
    } 
    get {
      uint ret = NWNXLibPINVOKE.TLK_FILE_HEADER_versionNum_get(swigCPtr);
      return ret;
    } 
  }

  public uint LanguageType {
    set {
      NWNXLibPINVOKE.TLK_FILE_HEADER_LanguageType_set(swigCPtr, value);
    } 
    get {
      uint ret = NWNXLibPINVOKE.TLK_FILE_HEADER_LanguageType_get(swigCPtr);
      return ret;
    } 
  }

  public uint nStrEntries {
    set {
      NWNXLibPINVOKE.TLK_FILE_HEADER_nStrEntries_set(swigCPtr, value);
    } 
    get {
      uint ret = NWNXLibPINVOKE.TLK_FILE_HEADER_nStrEntries_get(swigCPtr);
      return ret;
    } 
  }

  public uint strEntriesOffset {
    set {
      NWNXLibPINVOKE.TLK_FILE_HEADER_strEntriesOffset_set(swigCPtr, value);
    } 
    get {
      uint ret = NWNXLibPINVOKE.TLK_FILE_HEADER_strEntriesOffset_get(swigCPtr);
      return ret;
    } 
  }

  public TLK_FILE_HEADER() : this(NWNXLibPINVOKE.new_TLK_FILE_HEADER(), true) {
  }

}

}

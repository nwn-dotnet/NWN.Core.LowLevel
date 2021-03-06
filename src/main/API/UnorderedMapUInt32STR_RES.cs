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

public unsafe class UnorderedMapUInt32STR_RES : global::System.IDisposable, global::System.Collections.Generic.IDictionary<uint, STR_RES> {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  public UnorderedMapUInt32STR_RES(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  public UnorderedMapUInt32STR_RES(void* cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, (global::System.IntPtr)cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(UnorderedMapUInt32STR_RES obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~UnorderedMapUInt32STR_RES() {
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
          NWNXLibPINVOKE.delete_UnorderedMapUInt32STR_RES(swigCPtr);
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

  public static unsafe implicit operator void*(UnorderedMapUInt32STR_RES self) {
    return (void*)self.swigCPtr.Handle;
  }

  public static implicit operator System.IntPtr(UnorderedMapUInt32STR_RES self) {
    return self.swigCPtr.Handle;
  }

  public bool Equals(UnorderedMapUInt32STR_RES other) {
    if (ReferenceEquals(null, other)) {
      return false;
    }

    if (ReferenceEquals(this, other)) {
      return true;
    }

    return Pointer.Equals(other.Pointer);
  }

  public override bool Equals(object obj) {
    return ReferenceEquals(this, obj) || obj is UnorderedMapUInt32STR_RES other && Equals(other);
  }

  public override int GetHashCode() {
    return swigCPtr.Handle.GetHashCode();
  }

  public static bool operator ==(UnorderedMapUInt32STR_RES left, UnorderedMapUInt32STR_RES right) {
    return Equals(left, right);
  }

  public static bool operator !=(UnorderedMapUInt32STR_RES left, UnorderedMapUInt32STR_RES right) {
    return !Equals(left, right);
  }


  public STR_RES this[uint key] {
    get {
      return getitem(key);
    }

    set {
      setitem(key, value);
    }
  }

  public bool TryGetValue(uint key, out STR_RES value) {
    if (this.ContainsKey(key)) {
      value = this[key];
      return true;
    }
    value = default(STR_RES);
    return false;
  }

  public int Count {
    get {
      return (int)size();
    }
  }

  public bool IsReadOnly {
    get {
      return false;
    }
  }

  public global::System.Collections.Generic.ICollection<uint> Keys {
    get {
      global::System.Collections.Generic.ICollection<uint> keys = new global::System.Collections.Generic.List<uint>();
      int size = this.Count;
      if (size > 0) {
        global::System.IntPtr iter = create_iterator_begin();
        for (int i = 0; i < size; i++) {
          keys.Add(get_next_key(iter));
        }
        destroy_iterator(iter);
      }
      return keys;
    }
  }

  public global::System.Collections.Generic.ICollection<STR_RES> Values {
    get {
      global::System.Collections.Generic.ICollection<STR_RES> vals = new global::System.Collections.Generic.List<STR_RES>();
      foreach (global::System.Collections.Generic.KeyValuePair<uint, STR_RES> pair in this) {
        vals.Add(pair.Value);
      }
      return vals;
    }
  }

  public void Add(global::System.Collections.Generic.KeyValuePair<uint, STR_RES> item) {
    Add(item.Key, item.Value);
  }

  public bool Remove(global::System.Collections.Generic.KeyValuePair<uint, STR_RES> item) {
    if (Contains(item)) {
      return Remove(item.Key);
    } else {
      return false;
    }
  }

  public bool Contains(global::System.Collections.Generic.KeyValuePair<uint, STR_RES> item) {
    if (this[item.Key] == item.Value) {
      return true;
    } else {
      return false;
    }
  }

  public void CopyTo(global::System.Collections.Generic.KeyValuePair<uint, STR_RES>[] array) {
    CopyTo(array, 0);
  }

  public void CopyTo(global::System.Collections.Generic.KeyValuePair<uint, STR_RES>[] array, int arrayIndex) {
    if (array == null)
      throw new global::System.ArgumentNullException("array");
    if (arrayIndex < 0)
      throw new global::System.ArgumentOutOfRangeException("arrayIndex", "Value is less than zero");
    if (array.Rank > 1)
      throw new global::System.ArgumentException("Multi dimensional array.", "array");
    if (arrayIndex+this.Count > array.Length)
      throw new global::System.ArgumentException("Number of elements to copy is too large.");

    global::System.Collections.Generic.IList<uint> keyList = new global::System.Collections.Generic.List<uint>(this.Keys);
    for (int i = 0; i < keyList.Count; i++) {
      uint currentKey = keyList[i];
      array.SetValue(new global::System.Collections.Generic.KeyValuePair<uint, STR_RES>(currentKey, this[currentKey]), arrayIndex+i);
    }
  }

  global::System.Collections.Generic.IEnumerator<global::System.Collections.Generic.KeyValuePair<uint, STR_RES>> global::System.Collections.Generic.IEnumerable<global::System.Collections.Generic.KeyValuePair<uint, STR_RES>>.GetEnumerator() {
    return new UnorderedMapUInt32STR_RESEnumerator(this);
  }

  global::System.Collections.IEnumerator global::System.Collections.IEnumerable.GetEnumerator() {
    return new UnorderedMapUInt32STR_RESEnumerator(this);
  }

  public UnorderedMapUInt32STR_RESEnumerator GetEnumerator() {
    return new UnorderedMapUInt32STR_RESEnumerator(this);
  }

  // Type-safe enumerator
  /// Note that the IEnumerator documentation requires an InvalidOperationException to be thrown
  /// whenever the collection is modified. This has been done for changes in the size of the
  /// collection but not when one of the elements of the collection is modified as it is a bit
  /// tricky to detect unmanaged code that modifies the collection under our feet.
  public sealed class UnorderedMapUInt32STR_RESEnumerator : global::System.Collections.IEnumerator,
      global::System.Collections.Generic.IEnumerator<global::System.Collections.Generic.KeyValuePair<uint, STR_RES>>
  {
    private UnorderedMapUInt32STR_RES collectionRef;
    private global::System.Collections.Generic.IList<uint> keyCollection;
    private int currentIndex;
    private object currentObject;
    private int currentSize;

    public UnorderedMapUInt32STR_RESEnumerator(UnorderedMapUInt32STR_RES collection) {
      collectionRef = collection;
      keyCollection = new global::System.Collections.Generic.List<uint>(collection.Keys);
      currentIndex = -1;
      currentObject = null;
      currentSize = collectionRef.Count;
    }

    // Type-safe iterator Current
    public global::System.Collections.Generic.KeyValuePair<uint, STR_RES> Current {
      get {
        if (currentIndex == -1)
          throw new global::System.InvalidOperationException("Enumeration not started.");
        if (currentIndex > currentSize - 1)
          throw new global::System.InvalidOperationException("Enumeration finished.");
        if (currentObject == null)
          throw new global::System.InvalidOperationException("Collection modified.");
        return (global::System.Collections.Generic.KeyValuePair<uint, STR_RES>)currentObject;
      }
    }

    // Type-unsafe IEnumerator.Current
    object global::System.Collections.IEnumerator.Current {
      get {
        return Current;
      }
    }

    public bool MoveNext() {
      int size = collectionRef.Count;
      bool moveOkay = (currentIndex+1 < size) && (size == currentSize);
      if (moveOkay) {
        currentIndex++;
        uint currentKey = keyCollection[currentIndex];
        currentObject = new global::System.Collections.Generic.KeyValuePair<uint, STR_RES>(currentKey, collectionRef[currentKey]);
      } else {
        currentObject = null;
      }
      return moveOkay;
    }

    public void Reset() {
      currentIndex = -1;
      currentObject = null;
      if (collectionRef.Count != currentSize) {
        throw new global::System.InvalidOperationException("Collection modified.");
      }
    }

    public void Dispose() {
      currentIndex = -1;
      currentObject = null;
    }
  }


  public UnorderedMapUInt32STR_RES() : this(NWNXLibPINVOKE.new_UnorderedMapUInt32STR_RES__SWIG_0(), true) {
  }

  public UnorderedMapUInt32STR_RES(UnorderedMapUInt32STR_RES other) : this(NWNXLibPINVOKE.new_UnorderedMapUInt32STR_RES__SWIG_1(UnorderedMapUInt32STR_RES.getCPtr(other)), true) {
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
  }

  private uint size() {
    uint ret = NWNXLibPINVOKE.UnorderedMapUInt32STR_RES_size(swigCPtr);
    return ret;
  }

  public bool empty() {
    bool ret = NWNXLibPINVOKE.UnorderedMapUInt32STR_RES_empty(swigCPtr);
    return ret;
  }

  public void Clear() {
    NWNXLibPINVOKE.UnorderedMapUInt32STR_RES_Clear(swigCPtr);
  }

  private STR_RES getitem(uint key) {
    STR_RES ret = new STR_RES(NWNXLibPINVOKE.UnorderedMapUInt32STR_RES_getitem(swigCPtr, key), false);
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  private void setitem(uint key, STR_RES x) {
    NWNXLibPINVOKE.UnorderedMapUInt32STR_RES_setitem(swigCPtr, key, STR_RES.getCPtr(x));
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
  }

  public bool ContainsKey(uint key) {
    bool ret = NWNXLibPINVOKE.UnorderedMapUInt32STR_RES_ContainsKey(swigCPtr, key);
    return ret;
  }

  public void Add(uint key, STR_RES value) {
    NWNXLibPINVOKE.UnorderedMapUInt32STR_RES_Add(swigCPtr, key, STR_RES.getCPtr(value));
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
  }

  public bool Remove(uint key) {
    bool ret = NWNXLibPINVOKE.UnorderedMapUInt32STR_RES_Remove(swigCPtr, key);
    return ret;
  }

  private global::System.IntPtr create_iterator_begin() {
    global::System.IntPtr ret = NWNXLibPINVOKE.UnorderedMapUInt32STR_RES_create_iterator_begin(swigCPtr);
    return ret;
  }

  private uint get_next_key(global::System.IntPtr swigiterator) {
    uint ret = NWNXLibPINVOKE.UnorderedMapUInt32STR_RES_get_next_key(swigCPtr, swigiterator);
    return ret;
  }

  private void destroy_iterator(global::System.IntPtr swigiterator) {
    NWNXLibPINVOKE.UnorderedMapUInt32STR_RES_destroy_iterator(swigCPtr, swigiterator);
  }

}

}

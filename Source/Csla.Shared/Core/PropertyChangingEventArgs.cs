//-----------------------------------------------------------------------
// <copyright file="PropertyChangingEventArgs.cs" company="Marimer LLC">
//     Copyright (c) Marimer LLC. All rights reserved.
//     Website: https://cslanet.com
// </copyright>
// <summary>Arguments object containing information about</summary>
//-----------------------------------------------------------------------
#if PCL46 || PCL259
using System;

namespace Csla.Core
{
  /// <summary>
  /// Arguments object containing information about
  /// a property changing.
  /// </summary>
  public class PropertyChangingEventArgs : System.EventArgs
  {
    private string _propertyName = string.Empty;
    /// <summary>
    /// Creates an instnace of the object.
    /// </summary>
    /// <param name="propertyName">
    /// Name of the property that is changing.
    /// </param>
    public PropertyChangingEventArgs(string propertyName)
    {
      _propertyName = propertyName;
    }

    /// <summary>
    /// Gets the name of the changing property.
    /// </summary>
    public string PropertyName
    {
      get { return _propertyName; }
    }
  }
}
#endif
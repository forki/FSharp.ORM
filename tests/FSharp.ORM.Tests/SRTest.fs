﻿//----------------------------------------------------------------------------
//
// Copyright (c) 2011 The Soma Team. 
//
// This source code is subject to terms and conditions of the Apache License, Version 2.0. A 
// copy of the license can be found in the License.txt file at the root of this distribution. 
// By using this source code in any fashion, you are agreeing to be bound 
// by the terms of the Apache License, Version 2.0.
//
// You must not remove this notice, or any other, from this software.
//----------------------------------------------------------------------------

namespace FSharp.ORM.Tests

module SRTest =
  open System.Globalization
  open NUnit.Framework
  open FSharp.ORM

  [<Test>]
  [<SetUICulture("ja")>]
  let ``test jp`` () =
    let message = SR.SOMA0001 ()
    assert_equal "テスト" message.Text

  [<Test>]
  [<SetUICulture("")>]
  let ``test neutral`` () =
    let message = SR.SOMA0001 ()
    assert_equal "test" message.Text

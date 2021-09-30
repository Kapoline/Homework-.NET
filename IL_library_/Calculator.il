// Type: IL_library_.Calculator 
// Assembly: Homework_1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 7C6432AF-222C-45BE-9C86-AAD0CF94BF2A
// Location: C:\Users\User\Homework-.NET\Homework_1\bin\Debug\net5.0\Homework_1.dll
// Sequence point data from C:\Users\User\Homework-.NET\Homework_1\bin\Debug\net5.0\Homework_1.pdb
.assembly IL_library_
{
.ver 1:0:0:0
}
.class public auto ansi beforefieldinit
  IL_library_.Calculator
    extends [CORE_ASSEMBLY]System.Object
{

  .class nested public sealed auto ansi
    operations
      extends System.Enum
  {

    .field public specialname rtspecialname int32 value__

    .field public static literal valuetype IL_library_.Calculator/operations Plus = int32(0) // 0x00000000

    .field public static literal valuetype IL_library_.Calculator/operations Minus = int32(1) // 0x00000001

    .field public static literal valuetype IL_library_.Calculator/operations Mult = int32(2) // 0x00000002

    .field public static literal valuetype IL_library_.Calculator/operations Divide = int32(3) // 0x00000003

    .field public static literal valuetype IL_library_.Calculator/operations UnknownOperation = int32(4) // 0x00000004
  } // end of class operations

  .field public static class [System.Runtime]System.Exception DivideByZero

  .field public static class [System.Runtime]System.Exception WrongOperator

  .method public hidebysig static int32
    Calculate(
      int32 var1,
      int32 var2,
      valuetype IL_library_.Calculator/operations operation
    ) cil managed
  {
    .maxstack 2
    .locals init (
      [0] int32 result,
      [1] valuetype IL_library_.Calculator/operations V_1,
      [2] valuetype IL_library_.Calculator/operations V_2,
      [3] bool V_3,
      [4] int32 V_4
    )

    // [21 9 - 21 10]
    IL_0000: nop

    // [22 13 - 22 28]
    IL_0001: ldc.i4.0
    IL_0002: stloc.0      // result

    // [23 13 - 23 31]
    IL_0003: ldarg.2      // operation
    IL_0004: stloc.2      // V_2

    IL_0005: ldloc.2      // V_2
    IL_0006: stloc.1      // V_1

    IL_0007: ldloc.1      // V_1
    IL_0008: switch       (IL_0023, IL_0029, IL_002f, IL_0035, IL_004a)
    IL_0021: br.s         IL_0050

    // [26 21 - 26 42]
    IL_0023: ldarg.0      // var1
    IL_0024: ldarg.1      // var2
    IL_0025: add
    IL_0026: stloc.0      // result

    // [27 21 - 27 27]
    IL_0027: br.s         IL_0050

    // [29 21 - 29 42]
    IL_0029: ldarg.0      // var1
    IL_002a: ldarg.1      // var2
    IL_002b: sub
    IL_002c: stloc.0      // result

    // [30 21 - 30 27]
    IL_002d: br.s         IL_0050

    // [32 21 - 32 42]
    IL_002f: ldarg.0      // var1
    IL_0030: ldarg.1      // var2
    IL_0031: mul
    IL_0032: stloc.0      // result

    // [33 21 - 33 27]
    IL_0033: br.s         IL_0050

    // [35 21 - 35 35]
    IL_0035: ldarg.1      // var2
    IL_0036: ldc.i4.0
    IL_0037: ceq
    IL_0039: stloc.3      // V_3

    IL_003a: ldloc.3      // V_3
    IL_003b: brfalse.s    IL_0044

    // [36 21 - 36 22]
    IL_003d: nop

    // [37 25 - 37 44]
    IL_003e: ldsfld       class [System.Runtime]System.Exception IL_library_.Calculator::DivideByZero
    IL_0043: throw

    // [40 21 - 40 42]
    IL_0044: ldarg.0      // var1
    IL_0045: ldarg.1      // var2
    IL_0046: div
    IL_0047: stloc.0      // result

    // [41 21 - 41 27]
    IL_0048: br.s         IL_0050

    // [43 21 - 43 41]
    IL_004a: ldsfld       class [System.Runtime]System.Exception IL_library_.Calculator::WrongOperator
    IL_004f: throw

    // [45 13 - 45 27]
    IL_0050: ldloc.0      // result
    IL_0051: stloc.s      V_4
    IL_0053: br.s         IL_0055

    // [46 9 - 46 10]
    IL_0055: ldloc.s      V_4
    IL_0057: ret

  } // end of method Calculator::Calculate

  .method public hidebysig specialname rtspecialname instance void
    .ctor() cil managed
  {
    .maxstack 8

    IL_0000: ldarg.0      // this
    IL_0001: call         instance void [System.Runtime]System.Object::.ctor()
    IL_0006: nop
    IL_0007: ret

  } // end of method Calculator::.ctor

  .method private hidebysig static specialname rtspecialname void
    .cctor() cil managed
  {
    .maxstack 8

    // [17 9 - 17 101]
    IL_0000: ldstr        "can not divided by zero"
    IL_0005: newobj       instance void [System.Runtime]System.DivideByZeroException::.ctor(string)
    IL_000a: stsfld       class [System.Runtime]System.Exception IL_library_.Calculator::DivideByZero

    // [18 9 - 18 103]
    IL_000f: ldstr        "this operator does not exist"
    IL_0014: newobj       instance void [System.Runtime]System.ArgumentException::.ctor(string)
    IL_0019: stsfld       class [System.Runtime]System.Exception IL_library_.Calculator::WrongOperator
    IL_001e: ret

  } // end of method Calculator::.cctor
} // end of class IL_library_.Calculator

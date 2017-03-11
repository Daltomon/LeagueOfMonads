﻿using System;
using System.Diagnostics;
using System.Threading.Tasks;

// ReSharper disable InconsistentNaming

namespace LeagueOfMonads.NoLambda
{
   public static class ResultExtensions
   {
      // MAP #1

      [DebuggerHidden]
      public static Result<TResult, TFailure> Map<T, A, TResult, TFailure>(this Result<T, TFailure> m, Func<T, A, TResult> f, A a)
      {
         return m.Map(t => f(t, a));
      }

      [DebuggerHidden]
      public static Result<TResult, TFailure> Map<T, A, B, TResult, TFailure>(this Result<T, TFailure> m, Func<T, A, B, TResult> f, A a, B b)
      {
         return m.Map(t => f(t, a, b));
      }

      [DebuggerHidden]
      public static Result<TResult, TFailure> Map<T, A, B, C, TResult, TFailure>(this Result<T, TFailure> m, Func<T, A, B, C, TResult> f, A a, B b, C c)
      {
         return m.Map(t => f(t, a, b, c));
      }

      // MAP #2

      [DebuggerHidden]
      public static Task<Result<TResult, TFailure>> Map<T, A, TResult, TFailure>(this Result<T, TFailure> m, Func<T, A, Task<TResult>> f, A a)
      {
         return m.Map(t => f(t, a));
      }

      [DebuggerHidden]
      public static Task<Result<TResult, TFailure>> Map<T, A, B, TResult, TFailure>(this Result<T, TFailure> m, Func<T, A, B, Task<TResult>> f, A a, B b)
      {
         return m.Map(t => f(t, a, b));
      }

      [DebuggerHidden]
      public static Task<Result<TResult, TFailure>> Map<T, A, B, C, TResult, TFailure>(this Result<T, TFailure> m, Func<T, A, B, C, Task<TResult>> f, A a, B b, C c)
      {
         return m.Map(t => f(t, a, b, c));
      }

      // MAP EX #1

      [DebuggerHidden]
      public static async Task<Result<TResult, TFailure>> Map<T, A, TResult, TFailure>(this Task<Result<T, TFailure>> m, Func<T, A, TResult> f, A a)
      {
         return (await m).Map(t => f(t, a));
      }

      [DebuggerHidden]
      public static async Task<Result<TResult, TFailure>> Map<T, A, B, TResult, TFailure>(this Task<Result<T, TFailure>> m, Func<T, A, B, TResult> f, A a, B b)
      {
         return (await m).Map(t => f(t, a, b));
      }

      [DebuggerHidden]
      public static async Task<Result<TResult, TFailure>> Map<T, A, B, C, TResult, TFailure>(this Task<Result<T, TFailure>> m, Func<T, A, B, C, TResult> f, A a, B b, C c)
      {
         return (await m).Map(t => f(t, a, b, c));
      }

      // MAP EX #2

      [DebuggerHidden]
      public static async Task<Result<TResult, TFailure>> Map<T, A, TResult, TFailure>(this Task<Result<T, TFailure>> m, Func<T, A, Task<TResult>> f, A a)
      {
         return await (await m).Map(async t => await f(t, a));
      }

      [DebuggerHidden]
      public static async Task<Result<TResult, TFailure>> Map<T, A, B, TResult, TFailure>(this Task<Result<T, TFailure>> m, Func<T, A, B, Task<TResult>> f, A a, B b)
      {
         return await (await m).Map(async t => await f(t, a, b));
      }

      [DebuggerHidden]
      public static async Task<Result<TResult, TFailure>> Map<T, A, B, C, TResult, TFailure>(this Task<Result<T, TFailure>> m, Func<T, A, B, C, Task<TResult>> f, A a, B b, C c)
      {
         return await (await m).Map(async t => await f(t, a, b, c));
      }

      // TEE #1

      [DebuggerHidden]
      public static Result<T, TFailure> Tee<T, A, TFailure>(this Result<T, TFailure> m, Action<T, A> f, A a)
      {
         return m.Tee(t => f(t, a));
      }

      [DebuggerHidden]
      public static Result<T, TFailure> Tee<T, A, B, TFailure>(this Result<T, TFailure> m, Action<T, A, B> f, A a, B b)
      {
         return m.Tee(t => f(t, a, b));
      }

      [DebuggerHidden]
      public static Result<T, TFailure> Tee<T, A, B, C, TFailure>(this Result<T, TFailure> m, Action<T, A, B, C> f, A a, B b, C c)
      {
         return m.Tee(t => f(t, a, b, c));
      }

      // TEE #2

      [DebuggerHidden]
      public static Task<Result<T, TFailure>> Tea<T, A, TFailure>(this Result<T, TFailure> m, Func<T, A, Task> f, A a)
      {
         return m.Tea(t => f(t, a));
      }

      [DebuggerHidden]
      public static Task<Result<T, TFailure>> Tea<T, A, B, TFailure>(this Result<T, TFailure> m, Func<T, A, B, Task> f, A a, B b)
      {
         return m.Tea(t => f(t, a, b));
      }

      [DebuggerHidden]
      public static Task<Result<T, TFailure>> Tea<T, A, B, C, TFailure>(this Result<T, TFailure> m, Func<T, A, B, C, Task> f, A a, B b, C c)
      {
         return m.Tea(t => f(t, a, b, c));
      }

      // TEE EX #1

      [DebuggerHidden]
      public static async Task<Result<T, TFailure>> Tee<T, A, TFailure>(this Task<Result<T, TFailure>> m, Action<T, A> f, A a)
      {
         return (await m).Tee(t => f(t, a));
      }

      [DebuggerHidden]
      public static async Task<Result<T, TFailure>> Tee<T, A, B, TFailure>(this Task<Result<T, TFailure>> m, Action<T, A, B> f, A a, B b)
      {
         return (await m).Tee(t => f(t, a, b));
      }

      [DebuggerHidden]
      public static async Task<Result<T, TFailure>> Tee<T, A, B, C, TFailure>(this Task<Result<T, TFailure>> m, Action<T, A, B, C> f, A a, B b, C c)
      {
         return (await m).Tee(t => f(t, a, b, c));
      }

      // TEE EX #2

      [DebuggerHidden]
      public static async Task<Result<T, TFailure>> Tea<T, A, TFailure>(this Task<Result<T, TFailure>> m, Func<T, A, Task> f, A a)
      {
         return await (await m).Tea(t => f(t, a));
      }

      [DebuggerHidden]
      public static async Task<Result<T, TFailure>> Tea<T, A, B, TFailure>(this Task<Result<T, TFailure>> m, Func<T, A, B, Task> f, A a, B b)
      {
         return await (await m).Tea(t => f(t, a, b));
      }

      [DebuggerHidden]
      public static async Task<Result<T, TFailure>> Tea<T, A, B, C, TFailure>(this Task<Result<T, TFailure>> m, Func<T, A, B, C, Task> f, A a, B b, C c)
      {
         return await (await m).Tea(t => f(t, a, b, c));
      }
   }
}

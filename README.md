# 🃏 Gilbreath's Principle

*A card trick where the computer always knows whether you're telling the truth.*

Based on Paul Curry's version of the Gilbreath's principle, where he uses a deck of cards and his personal computer.

## 🎭 The Effect

Can you tell when someone is lying? And, more importantly, can you lie without being caught?

This is a C# console application inspired by a mathematical card trick that turns a computer into an apparently infallible lie detector.

The performer first tests the spectator's ability to detect lies. After a series of guesses, the roles are reversed: the spectator must decide whether to tell the truth or lie, while the computer claims to know which choice was made.

The result? An eerie little demonstration of mathematics disguised as magic. ✨

## 🎩 How It Works

The trick has two phases:

### 1. 🔍 Can You Detect a Lie?

The performer calls out the color of each card, red or black, while the spectator tries to identify when the performer is lying.

The computer keeps score, counting the spectator's correct guesses.

At the end, it announces the result:

> Seven correct out of ten!

### 2. 🤖 The Computer Knows

Now it's the spectator's turn.

For each card, the spectator secretly decides whether to tell the truth or lie, then enters:

- `r` — Red ❤️
- `b` — Black ♠️

The computer responds as though it can determine whether the spectator is telling the truth.

**The illusion:** The computer appears to read the spectator's mind, but the secret lies in the arrangement of the cards and the mathematics behind the trick.

## 🧠 The Mathematics Behind the Magic

The original trick relies on the **[Gilbreath Principle](https://en.wikipedia.org/wiki/Gilbreath_shuffle)**, a result in card magic involving the interaction between alternating card colors, cuts, and riffle shuffles.

With the right initial arrangement and shuffling procedure, the deck retains a useful red-black structure even though its order appears random. Dealing the cards into separate piles preserves relationships between their colors.

These relationships allow the performer to create the illusion that the computer can identify lies with uncanny accuracy.

The magic isn't in the computer's intelligence. It's in the mathematics. 🔢

## 🛠️ Built With

- 💻 C#
- 🖥️ .NET Console Application

## 🚀 Getting Started

Make sure you have the [.NET SDK](https://dotnet.microsoft.com/download) installed.

Clone the repository, navigate to the project directory, and run:

```bash
dotnet run
```

To execute the magic trick, you can find detailed instructions in the program.cs file.

## 🌱 Project Goals

- 🧩 Explore the relationship between mathematics and card magic.
- 💻 Implement a mathematical principle in a simple C# application.
- 🎭 Recreate the experience of an apparently impossible lie detector.
- 🔎 Experiment with how carefully structured information can create surprising effects.

## ℹ️ For more information

- Checkout **[Gilbreath Principle](https://en.wikipedia.org/wiki/Gilbreath_shuffle)**.

## 🤝 Contribution

Feel free to contribute to this project, new ideas coming soon...

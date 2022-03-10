using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests
{
    [TestFixture]
    internal class StackTests
    {
        private StackLists<string> stack;

        [SetUp]
        public void SetUp()
        {
            stack = new StackLists<string>();
        }

        [Test]
        public void Push_ArgumentIsNull_ThrowArgNullException()
        {
            Assert.That(() => stack.Push(null), Throws.ArgumentNullException);
        }

        [Test]
        public void Push_ArgumentValid_AddTheArgToList()
        {
            stack.Push("test");

            Assert.That(stack.Count, Is.EqualTo(1));
        }

        [Test]
        public void Count_EmptyStack_ReturnZero()
        {
            Assert.That(stack.Count, Is.EqualTo(0));
        }

        [Test]
        public void Pop_StackIsEmpty_ThrowInvalidOperationException()
        {
            Assert.That(() => stack.Pop(), Throws.InvalidOperationException);
        }

        [Test]
        public void Pop_StackNotEmpty_ReturnTopArgument()
        {
            // Arrange
            stack.Push("stack1");
            stack.Push("stack2");
            stack.Push("stack3");

            // Act
            var result = stack.Pop();

            // Assert
            Assert.That(result, Is.EqualTo("stack3"));
        }

        [Test]
        public void Pop_StackNotEmpty_RemoveTheTopArgument()
        {
            // Arrange
            stack.Push("stack1");
            stack.Push("stack2");
            stack.Push("stack3");

            // Act
            stack.Pop();

            // Assert
            Assert.That(stack.Count, Is.EqualTo(2));
        }

        [Test]
        public void Peek_StackIsEmpty_ThrowInvalidOperationException()
        {
            Assert.That(() => stack.Peek(), Throws.InvalidOperationException);
        }

        [Test]
        public void Peek_StackNotEmpty_ReturnTheTopElement()
        {
            stack.Push("stack1");
            stack.Push("stack2");
            stack.Push("stack3");

            var result = stack.Peek();

            Assert.That(result, Is.EqualTo("stack3"));
        }

        [Test]
        public void Peek_StackNotEmpty_DoesNotRemoveTheTopElementFromStack()
        {
            stack.Push("stack1");
            stack.Push("stack2");
            stack.Push("stack3");

            stack.Peek();

            Assert.That(stack.Count, Is.EqualTo(3));
        }
    }
}

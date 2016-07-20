using Core.Common.Core;
using Core.Common.Tests.Test_Classes;
using FluentValidation;

namespace Core.Common.Tests
{
    internal class TestClass : ObjectBase
    {
        string _CleanProp = string.Empty;
        string _DirtyProp = string.Empty;
        string _StringProp = string.Empty;
        TestChild _Child = new TestChild();
        CollectionBase<TestChild> _Children = new CollectionBase<TestChild>();
        TestChild _NotNavigableChild = new TestChild();

        public string CleanProp
        {
            get { return _CleanProp; }
            set
            {
                SetProperty(ref _CleanProp, value, false);
            }
        }

        public string DirtyProp
        {
            get { return _DirtyProp; }
            set { SetProperty(ref _DirtyProp, value); }
        }

        public string StringProp
        {
            get { return _StringProp; }
            set
            {
                if (_StringProp == value)
                    return;

                _StringProp = value;
                OnPropertyChanged("StringProp", false);
            }
        }

        public TestChild Child
        {
            get { return _Child; }
        }

        [NotNavigable]
        public TestChild NotNavigableChild
        {
            get { return _NotNavigableChild; }
        }

        public CollectionBase<TestChild> Children
        {
            get { return _Children; }
        }

        protected override IValidator GetValidator() => new TestClassValidator();
    }

    class TestClassValidator : AbstractValidator<TestClass>
    {
        public TestClassValidator()
        {
            RuleFor(a => a.StringProp).NotEmpty();
        }
    }
}

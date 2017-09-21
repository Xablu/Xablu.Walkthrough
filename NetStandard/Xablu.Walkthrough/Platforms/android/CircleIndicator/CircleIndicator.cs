using System;
using Android.Animation;
using Android.Annotation;
using Android.Content;
using Android.Content.Res;
using Android.Database;
using Android.Graphics.Drawables;
using Android.Graphics.Drawables.Shapes;
using Android.Support.V4.View;
using Android.Util;
using Android.Views;
using Android.Views.Animations;
using Android.Widget;
using static Android.Support.V4.View.ViewPager;

namespace Plugin.Xablu.Walkthrough.Indicator
{
    public class CircleIndicator : LinearLayout, IOnPageChangeListener
    {
        private const int DEFAULT_INDICATOR_WIDTH = 5;
        private ViewPager mViewPager;

        private int mLastPosition = -1;
        private int mIndicatorMargin = -1;
        private int mIndicatorWidth = -1;
        private int mIndicatorHeight = -1;

        private int mAnimatorResId = Resource.Animator.scale_with_alpha;
        private int mAnimatorReverseResId = 0;

        public int mIndicatorBackgroundResId = Resource.Drawable.white_radius;
        public int mIndicatorUnselectedBackgroundResId = Resource.Drawable.white_radius;

        public Drawable SelectedDrawable;
        public Drawable UnselectedDrawable;

        private Animator mAnimatorOut;
        private Animator mAnimatorIn;
        private Animator mImmediateAnimatorOut;
        private Animator mImmediateAnimatorIn;

        public DataSetObserver mInternalDataSetObserver { get; set; }

        public CircleIndicator(Context context) : base(context)
        {
            this.init(context, null);
        }

        public CircleIndicator(Context context, IAttributeSet attrs) : base(context, attrs)
        {
            this.init(context, attrs);
        }

        public CircleIndicator(Context context, IAttributeSet attrs, int defStyleAttr) : base(context, attrs,
            defStyleAttr)
        {
            this.init(context, attrs);
        }

        [TargetApi(Value = 21)] //lollipop
        public CircleIndicator(Context context, IAttributeSet attrs, int defStyleAttr, int defStyleRes) : base(context,
            attrs, defStyleAttr, defStyleRes)
        {
            this.init(context, attrs);
        }

        private void init(Context context, IAttributeSet attrs)
        {
            mInternalDataSetObserver = new CircleDataSetObserver(this);
            handleTypedArray(context, attrs);
            checkIndicatorConfig(context);
        }

        private void handleTypedArray(Context context, IAttributeSet attrs)
        {
            if (attrs == null)
                return;

            TypedArray typedArray = context.ObtainStyledAttributes(attrs, Resource.Styleable.CircleIndicator);

            this.mIndicatorWidth = typedArray.GetDimensionPixelSize(Resource.Styleable.CircleIndicator_ci_width, -1);
            this.mIndicatorHeight = typedArray.GetDimensionPixelSize(Resource.Styleable.CircleIndicator_ci_height, -1);
            this.mIndicatorMargin = typedArray.GetDimensionPixelSize(Resource.Styleable.CircleIndicator_ci_margin, -1);

            this.mAnimatorResId = typedArray.GetResourceId(Resource.Styleable.CircleIndicator_ci_animator,
                Resource.Animator.scale_with_alpha);
            this.mAnimatorReverseResId =
                typedArray.GetResourceId(Resource.Styleable.CircleIndicator_ci_animator_reverse, 0);
            this.mIndicatorBackgroundResId = typedArray.GetResourceId(Resource.Styleable.CircleIndicator_ci_drawable,
                Resource.Drawable.white_radius);
            this.mIndicatorUnselectedBackgroundResId =
                typedArray.GetResourceId(Resource.Styleable.CircleIndicator_ci_drawable_unselected,
                    this.mIndicatorBackgroundResId);

            Android.Widget.Orientation orientation =
                (Android.Widget.Orientation) typedArray.GetInt(Resource.Styleable.CircleIndicator_ci_orientation, -1);
            Orientation = (orientation == Android.Widget.Orientation.Vertical
                ? Android.Widget.Orientation.Vertical
                : Android.Widget.Orientation.Horizontal);

            int gravity = typedArray.GetInt(Resource.Styleable.CircleIndicator_ci_gravity, -1);
            SetGravity((gravity >= 0 ? (GravityFlags) gravity : GravityFlags.Center));

            typedArray.Recycle();
        }

        public void ConfigureIndicator(int indicatorWidth, int indicatorHeight, int indicatorMargin)
        {
            ConfigureIndicator(indicatorWidth, indicatorHeight, indicatorMargin, Resource.Animator.scale_with_alpha, 0,
                Resource.Drawable.white_radius, Resource.Drawable.white_radius);
        }

        public void ConfigureIndicator(int indicatorWidth, int indicatorHeight, int indicatorMargin, int animatorId,
            int animatorReverseId, int indicatorBackgroundId, int indicatorUnselectedBackgroundId)
        {
            mIndicatorWidth = indicatorWidth;
            mIndicatorHeight = indicatorHeight;
            mIndicatorMargin = indicatorMargin;

            mAnimatorResId = animatorId;
            mAnimatorReverseResId = animatorReverseId;
            mIndicatorBackgroundResId = indicatorBackgroundId;
            mIndicatorUnselectedBackgroundResId = indicatorUnselectedBackgroundId;

            checkIndicatorConfig(Context);
        }

        private void checkIndicatorConfig(Context context)
        {
            mIndicatorWidth = (mIndicatorWidth < 0) ? dip2px(DEFAULT_INDICATOR_WIDTH) : mIndicatorWidth;
            mIndicatorHeight = (mIndicatorHeight < 0) ? dip2px(DEFAULT_INDICATOR_WIDTH) : mIndicatorHeight;
            mIndicatorMargin = (mIndicatorMargin < 0) ? dip2px(DEFAULT_INDICATOR_WIDTH) : mIndicatorMargin;
            mAnimatorResId = (mAnimatorResId == 0) ? Resource.Animator.scale_with_alpha : mAnimatorResId;

            mAnimatorOut = createAnimatorOut(context);
            mImmediateAnimatorOut = createAnimatorOut(context);
            mImmediateAnimatorOut.SetDuration(0);

            mAnimatorIn = createAnimatorIn(context);
            mImmediateAnimatorIn = createAnimatorIn(context);
            mImmediateAnimatorIn.SetDuration(0);

            mIndicatorBackgroundResId = (mIndicatorBackgroundResId == 0)
                ? Resource.Drawable.white_radius
                : mIndicatorBackgroundResId;
            mIndicatorUnselectedBackgroundResId = (mIndicatorUnselectedBackgroundResId == 0)
                ? mIndicatorBackgroundResId
                : mIndicatorUnselectedBackgroundResId;
        }

        private Animator createAnimatorOut(Context context)
        {
            return AnimatorInflater.LoadAnimator(context, mAnimatorResId);
        }

        private Animator createAnimatorIn(Context context)
        {
            Animator animatorIn;
            if (mAnimatorReverseResId == 0)
            {
                animatorIn = AnimatorInflater.LoadAnimator(context, mAnimatorResId);
                animatorIn.SetInterpolator(new ReverseInterpolator());
            }
            else
            {
                animatorIn = AnimatorInflater.LoadAnimator(context, mAnimatorReverseResId);
            }
            return animatorIn;
        }

        public void SetViewPager(ViewPager viewPager)
        {
            mViewPager = viewPager;
            if (mViewPager != null && mViewPager.Adapter != null)
            {
                mLastPosition = -1;
                createIndicators();
                mViewPager.RemoveOnPageChangeListener(this);
                mViewPager.AddOnPageChangeListener(this);
                this.OnPageSelected(mViewPager.CurrentItem);
            }
        }

        public void OnPageScrollStateChanged(int state)
        {
        }

        public void OnPageScrolled(int position, float positionOffset, int positionOffsetPixels)
        {
        }

        public void OnPageSelected(int position)
        {
            if (mViewPager.Adapter == null || mViewPager.Adapter.Count <= 0)
                return;

            if (mAnimatorIn.IsRunning)
            {
                mAnimatorIn.End();
                mAnimatorIn.Cancel();
            }

            if (mAnimatorOut.IsRunning)
            {
                mAnimatorOut.End();
                mAnimatorOut.Cancel();
            }

            View currentIndicator;
            if (mLastPosition >= 0 && (currentIndicator = GetChildAt(mLastPosition)) != null)
            {
                if (SelectedDrawable != null)
                    currentIndicator.Background = SelectedDrawable;
                else
                    currentIndicator.SetBackgroundResource(mIndicatorUnselectedBackgroundResId);

                mAnimatorIn.SetTarget(currentIndicator);
                mAnimatorIn.Start();
            }

            View selectedIndicator = GetChildAt(position);
            if (selectedIndicator != null)
            {
                if (SelectedDrawable != null)
                    selectedIndicator.Background = SelectedDrawable;
                else
                    selectedIndicator.SetBackgroundResource(mIndicatorBackgroundResId);

                mAnimatorOut.SetTarget(selectedIndicator);
                mAnimatorOut.Start();
            }
            mLastPosition = position;
        }

        private void createIndicators()
        {
            RemoveAllViews();

            int count = mViewPager.Adapter.Count;
            if (count <= 0)
                return;

            int currentItem = mViewPager.CurrentItem;

            for (int i = 0; i < count; i++)
            {
                if (currentItem == i)
                {
                    if (SelectedDrawable != null)
                        addIndicator(Orientation, SelectedDrawable, mImmediateAnimatorOut);
                    else
                        addIndicator(Orientation, mIndicatorBackgroundResId, mImmediateAnimatorOut);
                }
                else
                {
                    if (UnselectedDrawable != null)
                        addIndicator(Orientation, UnselectedDrawable, mImmediateAnimatorIn);
                    else
                        addIndicator(Orientation, mIndicatorBackgroundResId, mImmediateAnimatorIn);
                }
            }
        }

        private void addIndicator(Android.Widget.Orientation orientation, Drawable backgroundDrawableId,
            Animator animator)
        {
            if (animator.IsRunning)
            {
                animator.End();
                animator.Cancel();
            }

            var indicator = new View(Context);
            indicator.Background = backgroundDrawableId;
            AddView(indicator, mIndicatorWidth, mIndicatorHeight);
            LayoutParams lp = (LayoutParams) indicator.LayoutParameters;

            if (orientation == Android.Widget.Orientation.Horizontal)
            {
                lp.LeftMargin = mIndicatorMargin;
                lp.RightMargin = mIndicatorMargin;
            }
            else
            {
                lp.TopMargin = mIndicatorMargin;
                lp.BottomMargin = mIndicatorMargin;
            }

            indicator.LayoutParameters = lp;

            animator.SetTarget(indicator);
            animator.Start();
        }

        private void addIndicator(Android.Widget.Orientation orientation, int backgroundDrawableId, Animator animator)
        {
            if (animator.IsRunning)
            {
                animator.End();
                animator.Cancel();
            }

            var indicator = new View(Context);
            indicator.SetBackgroundResource(backgroundDrawableId);
            AddView(indicator, mIndicatorWidth, mIndicatorHeight);
            LayoutParams lp = (LayoutParams) indicator.LayoutParameters;

            if (orientation == Android.Widget.Orientation.Horizontal)
            {
                lp.LeftMargin = mIndicatorMargin;
                lp.RightMargin = mIndicatorMargin;
            }
            else
            {
                lp.TopMargin = mIndicatorMargin;
                lp.BottomMargin = mIndicatorMargin;
            }

            indicator.LayoutParameters = lp;

            animator.SetTarget(indicator);
            animator.Start();
        }

        class ReverseInterpolator : Java.Lang.Object, IInterpolator
        {
            public float GetInterpolation(float value)
            {
                return Math.Abs(1.0f - value);
            }
        }

        public int dip2px(float dpValue)
        {
            var density = Context.Resources.DisplayMetrics.Density;
            return (int) (dpValue * density + 0.5f);
        }

        class CircleDataSetObserver : DataSetObserver
        {
            private CircleIndicator indicator;

            public CircleDataSetObserver(CircleIndicator indicator)
            {
                this.indicator = indicator;
            }

            public override void OnChanged()
            {
                base.OnChanged();
                if (indicator.mViewPager == null)
                    return;

                int newCount = indicator.mViewPager.Adapter.Count;
                int currentCount = indicator.ChildCount;

                if (newCount == currentCount)
                    return;
                else if (indicator.mLastPosition < newCount)
                    indicator.mLastPosition = indicator.mViewPager.CurrentItem;
                else
                    indicator.mLastPosition = -1;

                indicator.createIndicators();
            }
        }
    }
}
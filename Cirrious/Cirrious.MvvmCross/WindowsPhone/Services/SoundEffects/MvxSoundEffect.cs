using System;
using Cirrious.MvvmCross.Interfaces.Services;
using Cirrious.MvvmCross.Interfaces.Services.SoundEffects;
using Microsoft.Xna.Framework.Audio;

namespace Cirrious.MvvmCross.WindowsPhone.Services.SoundEffects
{
    public sealed class MvxSoundEffect : IMvxSoundEffect
    {
        private readonly SoundEffect _xnaSoundEffect;

        public MvxSoundEffect(SoundEffect xnaSoundEffect)
        {
            _xnaSoundEffect = xnaSoundEffect;
        }

        public void Dispose()
        {
            _xnaSoundEffect.Dispose();
        }

        public IMvxSoundEffectInstance CreateInstance()
        {
            return new MvxSoundEffectInstance(_xnaSoundEffect.CreateInstance());
            throw new NotImplementedException();
        }
    }
}
using System.Media;

namespace SaCheats
{
    class ModSoundPlayer
    {
        private const string path = "GtaSaSounds/cheat_activated.wav";
        public ModSoundPlayer() { }

        public void PlaySound()
        {
            SoundPlayer simpleSound = new SoundPlayer(path);
            simpleSound.Play();
        }
    }

}

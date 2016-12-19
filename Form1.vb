

Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        My.Computer.Audio.Play(My.Resources.Song1, AudioPlayMode.Background)



    End Sub







    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint



    End Sub
    Dim random1 As Byte
    Dim random2 As Byte
    Dim string1 As String
    Dim string2 As String

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = "" Then
            Label5.Visible = True
            Label5.Text = "Please enter a name to continue!"
        ElseIf TextBox1.Text.Length >= 15 Then
            Label5.Visible = True
            Label5.Text = "Too many characters!(max<15)"
        ElseIf TextBox1.Text.StartsWith(" ") Then
            Label5.Visible = True
            Label5.Text = "Please enter a name to continue!"
        ElseIf CheckBox1.Checked = False And CheckBox2.Checked = False Then
            Label10.Visible = True
            Label10.Text = "Select gender!"

        Else
            Panel1.Visible = False
            Label4.Visible = True
            Label6.Visible = True
            Label6.Visible = True
            Label7.Visible = True
            Dim onoma As String
            onoma = TextBox1.Text
            Label7.Text = "Dear " & onoma & "," & " here are your Tarot cards!"
            Button5.Visible = True
            Button6.Visible = True
        End If


        Randomize()
        random1 = (Rnd() * 21) + 1
        If random1 = 1 Then
            PictureBox1.Image = My.Resources.Image_1
            Label4.Text = "The Fool is shown at the beginning of his journey with unlimited potential.
The sun rising up behind him represents the beginning of his journey.
He is facing north-west, the direction of the unknown.
He is looking upwards, toward the sky, or Spirit.
He is about to step off a cliff into the material world but is he prepared?
He has all the tools and resources he needs in the bag on his staff but he has not opened the bag yet.
The white rose in his left hand represents purity and innocence.
He has a guardian in the little white dog who will protect him throughout his journey
but who will also push him to learn the lessons the Fool came here to learn.
The mountains behind the Fool represent the realms of Spirit that he has just left
and will spend his life trying to regain. "
        End If
        If random1 = 2 Then
            PictureBox1.Image = My.Resources.Image_2
            Label4.Text = "The Queen sits upon her throne that is decorated with lions facing opposing direction,
a symbol of fire and strength.
In her left hand and behind her are sunflowers, symbolising life, fertility, joy and satisfaction.
In her right hand is a wand which is beginning to blossom with life.
In these positive aspects, the Queen of Wands represents fidelity, warmth, and sustenance.
However, at her feet is a black cat, a symbol of the darker, lesser known side of this Queen.
Black cats are typically associated with magic and occultism.
The cat expresses the independent nature of this Queen and her interest in occult powers and the energy of magic.
There are other theories on what the cat symbolises, but as with all symbolism, the true 'meaning' is up to the observer. "
        End If
        If random1 = 3 Then
            PictureBox1.Image = My.Resources.Image_3
            Label4.Text = "The card of the Devil portrays a Satyr, a creature that is half man and half goat.
In many myths, the goat was considered an unclean and lustful animal.
However, the goat also symbolises the scapegoat, the person or thing upon
which people project the inferior side of themselves in order to feel better about themselves.
Thus the Devil is the scapegoat we blame for our troubles in life.
The Devil has the wings of a vampire bat, an animal that sucks the life blood out of its prey.
This is symbolic of what happens when we give full reign to the realm of our raw desires. We lose our vitality and life energy.
The Devil has an almost hypnotic stare, bringing those who come near him within his power.
Above him is an inverted pentagram, signifying the darker side of magic and occultism. "
        End If
        If random1 = 4 Then
            PictureBox1.Image = My.Resources.Image_4
            Label4.Text = "The Sun is an image of optimism and fulfilment, the dawn that follows the darkest night.
As the source of all life on earth, the Sun represents the source of life itself.
The child playing joyfully in the foreground represents the happiness of our inner spirit
when we are in tune with our truest Self.
He is naked, having nothing to hide. He has all the innocence and purity of childhood.
The white horse upon which the child rides represents strength and purity of spirit.
The horse is without a saddle and is controlled without the use of the hands.
This is a symbol of perfect control between the conscious and subconscious.
The child holds an orange banner in his left hand, showing that control has passed from the conscious to the subconscious.
The orange banner represents action and vibration, and the rays of the sun represent the same thing.
The straight rays are action while the wavy rays represent vibration.
The sunflowers in the background represent life and the fruitfulness of the spirit under the nourishment of the Sun.
There are four sunflowers, representing the four suits of the Minor Arcana, as well as the four elements.
The astrological correspondence to this card is the Sun, of course. "
        End If
        If random1 = 5 Then
            PictureBox1.Image = My.Resources.Image_5
            Label4.Text = "The Magician is associated with the planet,
Mercury and carries with it skill, logic, and intellect.
The number of the Magician is one, the number of beginnings.
The Magician is the bridge between the world of the spirit and the world of humanity.
His right hand holds a staff raised toward the sky and his left hand points to the earth.
He takes the power of the Universe and channels it through his own body and directs it to the physical plane.
Above the Magician’s head is the symbol of eternity and around his waist is a snake biting its own tail,
another symbol of eternity.
His magical table holds all four suits of the Tarot,
each of which represents one of the four primordial elements of the alchemists – earth, air, fire and water.
These symbolise the appropriate use of mind, heart, body and soul in the process of manifestation.
The Magician’s robe is white, symbolising the purity and innocence found in the Fool but his cloak is red,
representing worldly experience and knowledge.
In the bed of flowers at his feet this duality is repeated in the mix of pure white lilies and thorny red roses. "
        End If
        If random1 = 6 Then
            PictureBox1.Image = My.Resources.Image_6
            Label4.Text = "The Emperor is the complement to the Empress.
He is the Masculine Principle, the Animus and the Patriarch.
He represents power and authority, and his stern attitude is quite a departure from the sensual beauty of the Empress.
The Emperor has a long, white beard, a symbol of his experience.
As an archetype, it is common to see masculine figures of authority or father figures with long white beards.
It suggests that this man has acquired years of wisdom and experience
and he is worthy of listening to because he has seen first-hand the consequences of his actions. "
        End If
        If random1 = 7 Then
            PictureBox1.Image = My.Resources.Image_7
            Label4.Text = "The Death card shows Death himself riding on a white horse, holding a black and white flag.
Death is portrayed as a skeleton as the skeletal bones are the part of the body that survives death.
The armour he is wearing indicates that he is invincible and unconquerable. Indeed, no-one has yet triumphed over death.
The horse that Death rides is white, the colour of purity. Death is therefore the ultimate purifier.
All things are reborn fresh, new and pure. Notice even the bishop paying homage to him.
All sectors of the human race are represented here – men,
women and children – showing that Death does not discern between age, race or gender. "
        End If
        If random1 = 8 Then
            PictureBox1.Image = My.Resources.Image_8
            Label4.Text = "The Tower shows a tall tower pitched atop a craggy mountain.
Lightning strikes and flames burst from the building’s windows.
People are seen to be leaping from the tower in desperation, wanting to flee such destruction and turmoil.
The Tower signifies darkness and destruction on a physical scale, as opposed to a spiritual scale.
The Tower itself represents ambitions built on false premises.
The lightning bolt breaks down existing forms in order to make room for new ones.
It represents a sudden, momentary glimpse of truth,
a flash of inspiration that breaks down structures of ignorance and false reasoning.
Notice the lightning bolt is oriented left to right (from the perspective of the card),
from heaven to earth, and from Spirit to material.
The falling figures correspond to the chained prisoners in the Devil card.
They fall headfirst, because the sudden influx of spiritual consciousness represented
by the lightning flash completely upsets all our old notions about the relations between subconsciousness and self-consciousness. "
        End If
        If random1 = 9 Then
            PictureBox1.Image = My.Resources.Image_9
            Label4.Text = "The sign associated with the Lovers is Gemini.
The two figures in the Lovers card are blessed and protected by the angel in the clouds above them.
Angels, in general, represent the refinement of earthly desires. This angel, in particular, is Raphael, the angel of Air.
One of the associations of Air is communication, necessary for a healthy relationship.
The purple cloak on the angel represents royalty, a symbol of how important communication is.
The sun shines brightly over the couple, bringing warmth and security.
The earth at their feet is green and fertile and suggests life and happiness.
The snake in the fruit-laden tree behind the woman suggests the story of Adam and Eve,
the fall of humanity from grace, and the temptations of the world. The snake is also a symbol of the senses.
The flames behind the man represent the flames of passion, indicating the primary concern of the man.
There are twelve flames, representing the twelve zodiac signs, the symbol of time and eternity.
The man looks to the woman, who looks to the angel,
indicating the path of the conscious to the subconscious to the super-conscious,
or from physical desire to emotional needs to spiritual concerns.
The mountain is a phallic symbol, while the water is a feminine symbol, indicating balance between the two. "
        End If
        If random1 = 10 Then
            PictureBox1.Image = My.Resources.Image_10
            Label4.Text = "The Ace of Cups shows a hand holding a cup or chalice that is overflowing with five streams of water.
The hand that appears from the clouds represents our consciousness of spiritual energy and influence.
Radiating from the hand are rays which symbolises that you must always trust your inner feelings and your heart to lead the way.
This is your intuition and inner power talking to you.
The five streams represent the abundance and power of the spirit and the effect of spiritual energy upon our five senses.
A dove holding a wafer or small disc in its mouth descends from above,
signifying the incarnation and appearance of the spirit in the material world.
Below the hand is a great sea covered with lotus blossoms, symbolising the awakening of the human spirit.
The cup has an upside down M or a W inscribed on it. "
        End If
        If random1 = 11 Then
            PictureBox1.Image = My.Resources.Image_11
            Label4.Text = "In the Ace of Wands, a hand reaches out from a cloud,
as if a spiritual opportunity or offering is being made,
to grasp a wand that is still flowering, growing and developing.
The leaves floating down with the wind signify material and spiritual progress and balance.
In the distance on the left, there is a castle that represents the promise of what opportunities may come. "
        End If
        If random1 = 12 Then
            PictureBox1.Image = My.Resources.Image_12
            Label4.Text = "Under a golden sky, a woman gently pats a lion on its forehead and lower jaw.
The woman gazes down at the lion with a peaceful smile on her face and appears to be successfully taming this wild beast.
The fact that Strength is represented by a woman indicates that this card is not focused on pure physical strength.
She has the infinity symbol above her head, the same symbol seen in the Magician.
Her white robe is that of the innocent Fool, indicating a purity of spirit.
The blue mountain in the background is the same phallic symbol seen in the Lovers.
The lion is a symbol of our animal passions and desires. The lion itself is sticking out his tongue.
Animals that are preparing to bite do not stick their tongues out.
This lion is happy to submit and surrender to the woman.
The woman overcomes the lion with a quiet strength that can only come from within.
Her left arm represents mental effort, while the right arm represents physical effort.
Her right arm is merely holding, while the left arm is exerting all the pressure.
She wears a belt and crown of flowers and stands unprotected in an open green field.
The crown on her head represents the fullest, most beautiful expression of nature and transient life.
The sign associated with the Strength card is Leo. "
        End If
        If random1 = 13 Then
            PictureBox1.Image = My.Resources.Image_13
            Label4.Text = "The Chariot is associated with the astrological sign of Cancer.
He sits within a canopy of six-pointed stars, representing the celestial influences at work in this Tarot card.
The crescent moons on the man’s shoulders are outward facing to refer to the formative world.
The symbols on his tunic are alchemical symbols, representing the spiritual transformation of man.
The square signifies earth, a sign of strength of will.
The laurel and star crown indicate the highest attainment of man in spiritual evolution.
The wings on the Chariot represent inspiration and the Hindu sign of the union of positive and negative.
The black and white sphinxes have the same meaning. The Charioteer holds no reins, just the wand from the Magician card.
He controls through strength of will in the same way the Magician does.
The city is behind him, indicating he has turned his back on civilisation and materialism in order to seek spiritual matters.  "
        End If
        If random1 = 14 Then
            PictureBox1.Image = My.Resources.Image_14
            Label4.Text = "The Hermit stands alone on the top of a mountain with a lantern in his hand.
Mountains typically symbolise achievement, growth, and accomplishment.
The Hermit has attained his spiritual pinnacle and is ready to share his knowledge with others.
He is also continuing the path he has chosen, committed to his goal of ultimate awareness.
The star in the lantern is a six-pointed star (the Seal of Solomon, a symbol of wisdom).
The staff carried by the Hermit is the patriarch’s staff,
a symbol of the narrow path of initiation and an emblem of power and authority.
It represents the Hermit’s ability to use his isolation
and the knowledge he has gained as a tool upon his path to reach even higher levels of awareness.
The staff is in the Hermit’s left hand, the hand associated with the subconscious mind.
The snow at his feet represents the heights of spiritual attainment. He wears the grey cloak of invisibility.
His secrets are not for everyone, only for those earnestly seeking them and those willing to climb the heights to wisdom.
The astrological correspondence for this card is Virgo and the number 9,
signifies accomplishment, wisdom, the attainment of goals, as well as the search for truth. "
        End If
        If random1 = 15 Then
            PictureBox1.Image = My.Resources.Image_15
            Label4.Text = "Justice is ruled by Libra and the card number is 11.
The figure of Justice sits in her chair, cloaked in red and holding a sword in her right hand and scales in her left.
She wears a crown with a small square on it representing well-ordered thoughts. Notice the clasp holding the cloak together.
The square is the law protecting the circle and the eternal state of oneness within us all.
The sword is double-edged, cutting both ways, signifying impartiality. It is point-up, signifying victory.
The sword in her right hand demonstrates the logical, well-ordered mindset necessary to dispense fair justice.
The scales are in her left, intuitive hand, showing that logic must be balanced by the intuition.
A little white shoe pops out from beneath her cloak, reminding us of the spiritual consequences of our actions.
The purple cloth draped behind her signifies compassion and the grey pillars represent the constraints of the physical world. "
        End If
        If random1 = 16 Then
            PictureBox1.Image = My.Resources.Image_16
            Label4.Text = "The Star card shows a naked woman kneeling at the edge of a small pool.
The woman holds two containers of water. She pours the water out to nourish the earth and to continue the cycle of fertility,
represented by the lush greenery around her.
The other container pours the water onto dry land in five rivulets, representing the five senses.
The woman has one foot on the ground, representing her practical abilities and good common sense,
and the other foot in the water,
representing her intuition and inner resources, and listening to her inner voice.
Behind her, shines one large star and seven smaller stars, representing your chakras.
This represents a need to open your chakras and cleanse your aura. Notice all the stars have eight points.
The Star is associated with the number 17, which equals 8 (1+7=8).
Eight is Strength, the quality needed to accept your faults and love yourself in spite of them.
The bird in the tree in the background is the sacred ibis of thought, roosting in the tree of the mind.
The astrological sign of the Star is Aquarius. "
        End If
        If random1 = 17 Then
            PictureBox1.Image = My.Resources.Image_17
            Label4.Text = "On the Temperance card stands a winged angel.
The angel is actually a hermaphrodite (the child of Hermes and Aphrodite), showing a balance between the genders.
The angel has one foot on dry land, representative of the material world,
and one foot in the water, representative of the subconscious.
In this position, she also represents the need to ‘test the waters’ before jumping headfirst into unknown circumstances.
Here she tempers the whimsical flight of the Fool who jumps without giving a second thought.
The triangle inside the square on her robe represents the female being protected by natural law.
In her hands she holds two cups which she uses to mix water. The cups represent the sub- and super-conscious minds.
One cup can be thought of as holding hot water and the other cold water.
The water flowing between them is actually going from the lower cup to the higher one,
signifying rising from a lower plane to a higher one.
The temperate individual mixes the opposites and finds a balance in life by avoiding extremes.
The astrological sign is Sagittarius, the teacher of truth, enthusiasm, tolerance and beauty. "
        End If
        If random1 = 18 Then
            PictureBox1.Image = My.Resources.Image_18
            Label4.Text = "The Moon is the card of intuition, dreams and the unconscious.
The Moon provides light as a reflection of the Sun, yet this light is dim, uncertain,
and only vaguely illuminates our path as we journey toward higher consciousness.
The pool at the base of the card represents the subconscious mind
and the crayfish that crawls out of the pool symbolises the early stages of consciousness unfolding.
This creature also represents the often disturbing images that appear from our inner depths,
just as the dog and wolf at the beginning of the path represent the tamed and the wild aspects of our minds.
The path leads between two towers into the mountains in the distance, showing the way to the unconsciousness.
The astrological sign associated with this card is Pisces – psychic, receptive and mysterious. "
        End If
        If random1 = 19 Then
            PictureBox1.Image = My.Resources.Image_19
            Label4.Text = "In the centre of the World is a dancing figure,
rejoicing in the completion of the journey and celebrating not only this completion but also the new beginnings it promises.
The dancer has one leg crossed over the other, just like the Hanged man.
She is, in a sense, his opposite (i.e. the Hanged Man upright).
As the Hanged Man looks infinitely inward, the dancer in the World card looks infinitely outward.
In each of her hands she holds a wand or baton, representative of evolution and balance.
She is surrounded by a thick, green wreath, symbolic of success, victory, achievement and accomplishment,
and tied with the red ribbons of eternity.
The red ribbons form the infinity symbol,
representing the infinite rewards of positive effort in improving both ourselves and those around us.
Within the laurel wreath are stars of light indicating attainment of enlightenment or cosmic consciousness. "
        End If
        If random1 = 20 Then
            PictureBox1.Image = My.Resources.Image_20
            Label4.Text = "The Hanged Man shows a man suspended, upside-down, from the living World Tree, rooted in the underworld and supporting the heavens.
Given the serene expression on his face, it is believed he is hanging on the tree of his own will.
His right foot is bound to the tree but his left foot remains free, bent at the knee and tucked in behind his right leg.
His arms are bent, with hands held behind his back, forming an inverted triangle.
The man is wearing red pants representing human passion and the physical body, a blue coat for knowledge,
and yellow shoes representing his high ideals.
Around the Hanged Man’s head is a bright yellow halo showing spiritual attainment,
with the grey background suggesting invisibility (a good reminder to not flaunt your spirituality).
This is the card of ultimate surrender, of being suspended in time and of martyrdom and sacrifice to the greater good.
This is the archetype to meditate on to help break old patterns of behaviour and bad habits that restrict you.
The Hanged Man’s number is 12 – a higher octave of the number 3,
representing careful planning and orderly growth leading to spiritual development.
1 (beginning) + 2 (the reasoning force) = 3 (the product of rebirth).
The ruling planet is Neptune, the planet of self-sacrifice and idealism.  "
        End If
        If random1 = 21 Then
            PictureBox1.Image = My.Resources.Image_21
            Label4.Text = "The Empress is the archetypal Earth Mother, the Anima, the Feminine Principle, Demeter,
Freyja and the Goddess of Fertility.
Ruled by Venus, the planet of love, creativity, fertility, art, harmony, luxury, beauty and grace.
The main feature of this card is the Empress herself, a full-figured woman with blond hair and a peaceful and calm aura about her.
On her head she wears a crown of stars, showing her connection with the mystical realm of angels and fairies.
She is dressed in a patterned robe of pomegranates, symbolic of fertility
and is seated upon a luxurious array of cushions and flowing red velvet with the symbol of Venus emblazoned upon it.
The Empress is surrounded by a beautiful, lush forest with a stream running through it,
demonstrating the Empress’s deep emotional connection with Mother Earth and life.
She draws her sense of peace from the trees and the water and is rejuvenated by the energy of nature.
In the foreground, golden wheat springs from the ground, reflecting abundance from a recent harvest. "
        End If
        If random1 = 22 Then
            PictureBox1.Image = My.Resources.Image_22
            Label4.Text = "The Judgement card shows a number of naked men,
women and children rising up from their graves, arms outspread and responding to the trumpet call of the archangel,
Gabriel, who hovers high above them.
The people are appealing to the angel, ready to be judged by the power of the Universe.
In the background, there are huge mountains, or even tidal waves,
which signify insurmountable obstacles and the impossibility of avoiding judgment.
The ocean represents the end of the river that flows through the Major Arcana, starting with the Empress.
Gabriel’s banner is red on white, the same as the Magician’s clothing.
As with everything in life, the beginning is woven irrevocably into the end and the end eventually leads to a new beginning.
The planetary ruler of this card is Pluto, the ruler of the underworld. "
        End If

        Randomize()
        random2 = (Rnd() * 21) + 1
        If random2 = 1 Then
            PictureBox2.Image = My.Resources.Image_1
            Label6.Text = "The Fool is shown at the beginning of his journey with unlimited potential.
The sun rising up behind him represents the beginning of his journey.
He is facing north-west, the direction of the unknown.
He is looking upwards, toward the sky, or Spirit.
He is about to step off a cliff into the material world but is he prepared?
He has all the tools and resources he needs in the bag on his staff but he has not opened the bag yet.
The white rose in his left hand represents purity and innocence.
He has a guardian in the little white dog who will protect him throughout his journey
but who will also push him to learn the lessons the Fool came here to learn.
The mountains behind the Fool represent the realms of Spirit that he has just left
and will spend his life trying to regain. "
        End If
        If random2 = 2 Then
            PictureBox2.Image = My.Resources.Image_2
            Label6.Text = "The Queen sits upon her throne that is decorated with lions facing opposing direction,
a symbol of fire and strength.
In her left hand and behind her are sunflowers, symbolising life, fertility, joy and satisfaction.
In her right hand is a wand which is beginning to blossom with life.
In these positive aspects, the Queen of Wands represents fidelity, warmth, and sustenance.
However, at her feet is a black cat, a symbol of the darker, lesser known side of this Queen.
Black cats are typically associated with magic and occultism.
The cat expresses the independent nature of this Queen and her interest in occult powers and the energy of magic.
There are other theories on what the cat symbolises, but as with all symbolism, the true 'meaning' is up to the observer. "
        End If
        If random2 = 3 Then
            PictureBox2.Image = My.Resources.Image_3
            Label6.Text = "The card of the Devil portrays a Satyr, a creature that is half man and half goat.
In many myths, the goat was considered an unclean and lustful animal.
However, the goat also symbolises the scapegoat, the person or thing upon
which people project the inferior side of themselves in order to feel better about themselves.
Thus the Devil is the scapegoat we blame for our troubles in life.
The Devil has the wings of a vampire bat, an animal that sucks the life blood out of its prey.
This is symbolic of what happens when we give full reign to the realm of our raw desires. We lose our vitality and life energy.
The Devil has an almost hypnotic stare, bringing those who come near him within his power.
Above him is an inverted pentagram, signifying the darker side of magic and occultism. "
        End If
        If random2 = 4 Then
            PictureBox2.Image = My.Resources.Image_4
            Label6.Text = "The Sun is an image of optimism and fulfilment, the dawn that follows the darkest night.
As the source of all life on earth, the Sun represents the source of life itself.
The child playing joyfully in the foreground represents the happiness of our inner spirit
when we are in tune with our truest Self.
He is naked, having nothing to hide. He has all the innocence and purity of childhood.
The white horse upon which the child rides represents strength and purity of spirit.
The horse is without a saddle and is controlled without the use of the hands.
This is a symbol of perfect control between the conscious and subconscious.
The child holds an orange banner in his left hand, showing that control has passed from the conscious to the subconscious.
The orange banner represents action and vibration, and the rays of the sun represent the same thing.
The straight rays are action while the wavy rays represent vibration.
The sunflowers in the background represent life and the fruitfulness of the spirit under the nourishment of the Sun.
There are four sunflowers, representing the four suits of the Minor Arcana, as well as the four elements.
The astrological correspondence to this card is the Sun, of course. "
        End If
        If random2 = 5 Then
            PictureBox2.Image = My.Resources.Image_5
            Label6.Text = "The Magician is associated with the planet,
Mercury and carries with it skill, logic, and intellect.
The number of the Magician is one, the number of beginnings.
The Magician is the bridge between the world of the spirit and the world of humanity.
His right hand holds a staff raised toward the sky and his left hand points to the earth.
He takes the power of the Universe and channels it through his own body and directs it to the physical plane.
Above the Magician’s head is the symbol of eternity and around his waist is a snake biting its own tail,
another symbol of eternity.
His magical table holds all four suits of the Tarot,
each of which represents one of the four primordial elements of the alchemists – earth, air, fire and water.
These symbolise the appropriate use of mind, heart, body and soul in the process of manifestation.
The Magician’s robe is white, symbolising the purity and innocence found in the Fool but his cloak is red,
representing worldly experience and knowledge.
In the bed of flowers at his feet this duality is repeated in the mix of pure white lilies and thorny red roses. "
        End If
        If random2 = 6 Then
            PictureBox2.Image = My.Resources.Image_6
            Label6.Text = "The Emperor is the complement to the Empress.
He is the Masculine Principle, the Animus and the Patriarch.
He represents power and authority, and his stern attitude is quite a departure from the sensual beauty of the Empress.
The Emperor has a long, white beard, a symbol of his experience.
As an archetype, it is common to see masculine figures of authority or father figures with long white beards.
It suggests that this man has acquired years of wisdom and experience
and he is worthy of listening to because he has seen first-hand the consequences of his actions. "
        End If
        If random2 = 7 Then
            PictureBox2.Image = My.Resources.Image_7
            Label6.Text = "The Death card shows Death himself riding on a white horse, holding a black and white flag.
Death is portrayed as a skeleton as the skeletal bones are the part of the body that survives death.
The armour he is wearing indicates that he is invincible and unconquerable. Indeed, no-one has yet triumphed over death.
The horse that Death rides is white, the colour of purity. Death is therefore the ultimate purifier.
All things are reborn fresh, new and pure. Notice even the bishop paying homage to him.
All sectors of the human race are represented here – men,
women and children – showing that Death does not discern between age, race or gender. "
        End If
        If random2 = 8 Then
            PictureBox2.Image = My.Resources.Image_8
            Label6.Text = "The Tower shows a tall tower pitched atop a craggy mountain.
Lightning strikes and flames burst from the building’s windows.
People are seen to be leaping from the tower in desperation, wanting to flee such destruction and turmoil.
The Tower signifies darkness and destruction on a physical scale, as opposed to a spiritual scale.
The Tower itself represents ambitions built on false premises.
The lightning bolt breaks down existing forms in order to make room for new ones.
It represents a sudden, momentary glimpse of truth,
a flash of inspiration that breaks down structures of ignorance and false reasoning.
Notice the lightning bolt is oriented left to right (from the perspective of the card),
from heaven to earth, and from Spirit to material.
The falling figures correspond to the chained prisoners in the Devil card.
They fall headfirst, because the sudden influx of spiritual consciousness represented
by the lightning flash completely upsets all our old notions about the relations
between subconsciousness and self-consciousness. "
        End If
        If random2 = 9 Then
            PictureBox2.Image = My.Resources.Image_9
            Label6.Text = "The sign associated with the Lovers is Gemini.
The two figures in the Lovers card are blessed and protected by the angel in the clouds above them.
Angels, in general, represent the refinement of earthly desires. This angel, in particular, is Raphael, the angel of Air.
One of the associations of Air is communication, necessary for a healthy relationship.
The purple cloak on the angel represents royalty, a symbol of how important communication is.
The sun shines brightly over the couple, bringing warmth and security.
The earth at their feet is green and fertile and suggests life and happiness.
The snake in the fruit-laden tree behind the woman suggests the story of Adam and Eve,
the fall of humanity from grace, and the temptations of the world. The snake is also a symbol of the senses.
The flames behind the man represent the flames of passion, indicating the primary concern of the man.
There are twelve flames, representing the twelve zodiac signs, the symbol of time and eternity.
The man looks to the woman, who looks to the angel,
indicating the path of the conscious to the subconscious to the super-conscious,
or from physical desire to emotional needs to spiritual concerns.
The mountain is a phallic symbol, while the water is a feminine symbol, indicating balance between the two. "
        End If
        If random2 = 10 Then
            PictureBox2.Image = My.Resources.Image_10
            Label6.Text = "The Ace of Cups shows a hand holding a cup or chalice that is overflowing with five streams of water.
The hand that appears from the clouds represents our consciousness of spiritual energy and influence.
Radiating from the hand are rays which symbolises that you must always trust your inner feelings and your heart to lead the way.
This is your intuition and inner power talking to you.
The five streams represent the abundance and power of the spirit and the effect of spiritual energy upon our five senses.
A dove holding a wafer or small disc in its mouth descends from above,
signifying the incarnation and appearance of the spirit in the material world.
Below the hand is a great sea covered with lotus blossoms, symbolising the awakening of the human spirit.
The cup has an upside down M or a W inscribed on it. "
        End If
        If random2 = 11 Then
            PictureBox2.Image = My.Resources.Image_11
            Label6.Text = "In the Ace of Wands, a hand reaches out from a cloud,
as if a spiritual opportunity or offering is being made,
to grasp a wand that is still flowering, growing and developing.
The leaves floating down with the wind signify material and spiritual progress and balance.
In the distance on the left, there is a castle that represents the promise of what opportunities may come. "
        End If
        If random2 = 12 Then
            PictureBox2.Image = My.Resources.Image_12
            Label6.Text = "Under a golden sky, a woman gently pats a lion on its forehead and lower jaw.
The woman gazes down at the lion with a peaceful smile on her face and appears to be successfully taming this wild beast.
The fact that Strength is represented by a woman indicates that this card is not focused on pure physical strength.
She has the infinity symbol above her head, the same symbol seen in the Magician.
Her white robe is that of the innocent Fool, indicating a purity of spirit.
The blue mountain in the background is the same phallic symbol seen in the Lovers.
The lion is a symbol of our animal passions and desires. The lion itself is sticking out his tongue.
Animals that are preparing to bite do not stick their tongues out.
This lion is happy to submit and surrender to the woman.
The woman overcomes the lion with a quiet strength that can only come from within.
Her left arm represents mental effort, while the right arm represents physical effort.
Her right arm is merely holding, while the left arm is exerting all the pressure.
She wears a belt and crown of flowers and stands unprotected in an open green field.
The crown on her head represents the fullest, most beautiful expression of nature and transient life.
The sign associated with the Strength card is Leo. "
        End If
        If random2 = 13 Then
            PictureBox2.Image = My.Resources.Image_13
            Label6.Text = "The Chariot is associated with the astrological sign of Cancer.
He sits within a canopy of six-pointed stars, representing the celestial influences at work in this Tarot card.
The crescent moons on the man’s shoulders are outward facing to refer to the formative world.
The symbols on his tunic are alchemical symbols, representing the spiritual transformation of man.
The square signifies earth, a sign of strength of will.
The laurel and star crown indicate the highest attainment of man in spiritual evolution.
The wings on the Chariot represent inspiration and the Hindu sign of the union of positive and negative.
The black and white sphinxes have the same meaning. The Charioteer holds no reins, just the wand from the Magician card.
He controls through strength of will in the same way the Magician does.
The city is behind him, indicating he has turned his back on civilisation and materialism in order to seek spiritual matters.  "
        End If
        If random2 = 14 Then
            PictureBox2.Image = My.Resources.Image_14
            Label6.Text = "The Hermit stands alone on the top of a mountain with a lantern in his hand.
Mountains typically symbolise achievement, growth, and accomplishment.
The Hermit has attained his spiritual pinnacle and is ready to share his knowledge with others.
He is also continuing the path he has chosen, committed to his goal of ultimate awareness.
The star in the lantern is a six-pointed star (the Seal of Solomon, a symbol of wisdom).
The staff carried by the Hermit is the patriarch’s staff,
a symbol of the narrow path of initiation and an emblem of power and authority.
It represents the Hermit’s ability to use his isolation
and the knowledge he has gained as a tool upon his path to reach even higher levels of awareness.
The staff is in the Hermit’s left hand, the hand associated with the subconscious mind.
The snow at his feet represents the heights of spiritual attainment. He wears the grey cloak of invisibility.
His secrets are not for everyone, only for those earnestly seeking them and those willing to climb the heights to wisdom.
The astrological correspondence for this card is Virgo and the number 9,
signifies accomplishment, wisdom, the attainment of goals, as well as the search for truth. "
        End If
        If random2 = 15 Then
            PictureBox2.Image = My.Resources.Image_15
            Label6.Text = "Justice is ruled by Libra and the card number is 11.
The figure of Justice sits in her chair, cloaked in red and holding a sword in her right hand and scales in her left.
She wears a crown with a small square on it representing well-ordered thoughts. Notice the clasp holding the cloak together.
The square is the law protecting the circle and the eternal state of oneness within us all.
The sword is double-edged, cutting both ways, signifying impartiality. It is point-up, signifying victory.
The sword in her right hand demonstrates the logical, well-ordered mindset necessary to dispense fair justice.
The scales are in her left, intuitive hand, showing that logic must be balanced by the intuition.
A little white shoe pops out from beneath her cloak, reminding us of the spiritual consequences of our actions.
The purple cloth draped behind her signifies compassion and the grey pillars represent the constraints of the physical world. "
        End If
        If random2 = 16 Then
            PictureBox2.Image = My.Resources.Image_16
            Label6.Text = "The Star card shows a naked woman kneeling at the edge of a small pool.
The woman holds two containers of water.
She pours the water out to nourish the earth and to continue the cycle of fertility,
represented by the lush greenery around her. The other container pours the water onto dry land in five rivulets,
representing the five senses.
The woman has one foot on the ground, representing her practical abilities and good common sense,
and the other foot in the water,
representing her intuition and inner resources, and listening to her inner voice.
Behind her, shines one large star and seven smaller stars, representing your chakras.
This represents a need to open your chakras and cleanse your aura. Notice all the stars have eight points.
The Star is associated with the number 17, which equals 8 (1+7=8).
Eight is Strength, the quality needed to accept your faults and love yourself in spite of them.
The bird in the tree in the background is the sacred ibis of thought, roosting in the tree of the mind.
The astrological sign of the Star is Aquarius. "
        End If
        If random2 = 17 Then
            PictureBox2.Image = My.Resources.Image_17
            Label6.Text = "On the Temperance card stands a winged angel.
The angel is actually a hermaphrodite (the child of Hermes and Aphrodite), showing a balance between the genders.
The angel has one foot on dry land, representative of the material world, and one foot in the water,
representative of the subconscious.
In this position, she also represents the need to ‘test the waters’ before jumping headfirst into unknown circumstances.
Here she tempers the whimsical flight of the Fool who jumps without giving a second thought.
The triangle inside the square on her robe represents the female being protected by natural law.
In her hands she holds two cups which she uses to mix water. The cups represent the sub- and super-conscious minds.
One cup can be thought of as holding hot water and the other cold water.
The water flowing between them is actually going from the lower cup to the higher one,
signifying rising from a lower plane to a higher one.
The temperate individual mixes the opposites and finds a balance in life by avoiding extremes.
The astrological sign is Sagittarius, the teacher of truth, enthusiasm, tolerance and beauty. "
        End If
        If random2 = 18 Then
            PictureBox2.Image = My.Resources.Image_18
            Label6.Text = "The Moon is the card of intuition, dreams and the unconscious.
The Moon provides light as a reflection of the Sun, yet this light is dim, uncertain,
and only vaguely illuminates our path as we journey toward higher consciousness.
The pool at the base of the card represents the subconscious mind
and the crayfish that crawls out of the pool symbolises the early stages of consciousness unfolding.
This creature also represents the often disturbing images that appear from our inner depths,
just as the dog and wolf at the beginning of the path represent the tamed and the wild aspects of our minds.
The path leads between two towers into the mountains in the distance, showing the way to the unconsciousness.
The astrological sign associated with this card is Pisces – psychic, receptive and mysterious. "
        End If
        If random2 = 19 Then
            PictureBox2.Image = My.Resources.Image_19
            Label6.Text = "In the centre of the World is a dancing figure,
rejoicing in the completion of the journey and celebrating not only this completion,
but also the new beginnings it promises.
The dancer has one leg crossed over the other, just like the Hanged man.
She is, in a sense, his opposite (i.e. the Hanged Man upright).
As the Hanged Man looks infinitely inward, the dancer in the World card looks infinitely outward.
In each of her hands she holds a wand or baton, representative of evolution and balance.
She is surrounded by a thick, green wreath, symbolic of success, victory, achievement and accomplishment,
and tied with the red ribbons of eternity.
The red ribbons form the infinity symbol,
representing the infinite rewards of positive effort in improving both ourselves and those around us.
Within the laurel wreath are stars of light indicating attainment of enlightenment or cosmic consciousness. "
        End If
        If random2 = 20 Then
            PictureBox2.Image = My.Resources.Image_20
            Label6.Text = "The Hanged Man shows a man suspended, upside-down, from the living World Tree,
rooted in the underworld and supporting the heavens.
Given the serene expression on his face, it is believed he is hanging on the tree of his own will.
His right foot is bound to the tree but his left foot remains free, bent at the knee and tucked in behind his right leg.
His arms are bent, with hands held behind his back, forming an inverted triangle.
The man is wearing red pants representing human passion and the physical body, a blue coat for knowledge,
and yellow shoes representing his high ideals.
Around the Hanged Man’s head is a bright yellow halo showing spiritual attainment,
with the grey background suggesting invisibility (a good reminder to not flaunt your spirituality).
This is the card of ultimate surrender, of being suspended in time and of martyrdom and sacrifice to the greater good.
This is the archetype to meditate on to help break old patterns of behaviour and bad habits that restrict you.
The Hanged Man’s number is 12 – a higher octave of the number 3,
representing careful planning and orderly growth leading to spiritual development.
1 (beginning) + 2 (the reasoning force) = 3 (the product of rebirth).
The ruling planet is Neptune, the planet of self-sacrifice and idealism.  "
        End If
        If random2 = 21 Then
            PictureBox2.Image = My.Resources.Image_21
            Label6.Text = "The Empress is the archetypal Earth Mother, the Anima, the Feminine Principle, Demeter,
Freyja and the Goddess of Fertility.
Ruled by Venus, the planet of love, creativity, fertility, art, harmony, luxury, beauty and grace.
The main feature of this card is the Empress herself, a full-figured woman with blond hair and a peaceful and calm aura about her.
On her head she wears a crown of stars, showing her connection with the mystical realm of angels and fairies.
She is dressed in a patterned robe of pomegranates, symbolic of fertility
and is seated upon a luxurious array of cushions and flowing red velvet with the symbol of Venus emblazoned upon it.
The Empress is surrounded by a beautiful, lush forest with a stream running through it,
demonstrating the Empress’s deep emotional connection with Mother Earth and life.
She draws her sense of peace from the trees and the water and is rejuvenated by the energy of nature.
In the foreground, golden wheat springs from the ground, reflecting abundance from a recent harvest. "
        End If
        If random2 = 22 Then
            PictureBox2.Image = My.Resources.Image_22
            Label6.Text = "The Judgement card shows a number of naked men,
women and children rising up from their graves, arms outspread and responding to the trumpet call of the archangel,
Gabriel, who hovers high above them.
The people are appealing to the angel, ready to be judged by the power of the Universe.
In the background, there are huge mountains, or even tidal waves,
which signify insurmountable obstacles and the impossibility of avoiding judgment.
The ocean represents the end of the river that flows through the Major Arcana, starting with the Empress.
Gabriel’s banner is red on white, the same as the Magician’s clothing.
As with everything in life, the beginning is woven irrevocably into the end and the end eventually leads to a new beginning.
The planetary ruler of this card is Pluto, the ruler of the underworld. "
        End If

        Console.Beep(500, 50)

        string1 = random1
        string2 = random2
        If string1 = string2 Then



            Randomize()
            random1 = (Rnd() * 21) + 1
            Randomize()
            random2 = (Rnd() * 21) + 1
        End If



    End Sub



    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            CheckBox2.Checked = False
        End If
    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged
        If CheckBox2.Checked = True Then
            CheckBox1.Checked = False
        End If
    End Sub



    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Console.Beep(500, 50)
        Me.Close()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs)
        Console.Beep(500, 50)
        Me.Close()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Panel1.Visible = True
        Label4.Visible = False
        Label6.Visible = False
        Label7.Visible = False
        Button5.Visible = False
        TextBox1.Text = ""
        Label4.Text = ""
        Label6.Text = ""
        Label5.Visible = False
        Button6.Visible = False
        CheckBox2.Checked = False
        CheckBox1.Checked = False
        Label10.Visible = False
        Console.Beep(500, 50)
    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Console.Beep(500, 50)
        tab.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Console.Beep(500, 50)
        Panel2.Dock = DockStyle.Fill
        Button7.Visible = True
        Panel2.Visible = True
        Panel1.Visible = False
        Label8.Visible = True
        Label8.Text = "

  ABOUT TAROT

Tarotology is the theoretical basis for the reading of Tarot cards,
a subset of cartomancy,
which is the practice of using cards to gain insight into the past,
present or future by posing a question to the cards.
The reasoning behind this practice ranges
from believing the result is guided by a spiritual force,
to belief that the cards are instruments used to tap either
into a collective unconscious or into the subject's own creative,
brainstorming subconscious.Tarot cards were originally used in games
and are still used for that purpose in many parts of Europe.
Tarot cards are considered pseudoscience,
and the readings made from the cards have no scientific evidence or merit."
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Console.Beep(500, 50)
        CheckBox2.Checked = False
        CheckBox1.Checked = False
        Label5.Visible = False
        Panel2.Visible = False
        Panel1.Visible = True
        Label8.Visible = False
        TextBox1.Text = ""
        Label10.Visible = False
    End Sub

    Private Sub Button6_Click_1(sender As Object, e As EventArgs) Handles Button6.Click
        Console.Beep(500, 50)
        Label5.Visible = False
        Button6.Visible = False
        Label4.Visible = False
        Label6.Visible = False
        Label7.Visible = False
        Button5.Visible = False
        Panel3.Dock = DockStyle.Fill
        Panel3.Visible = True
        Button8.Visible = True
        Label9.Visible = True
        PictureBox3.Visible = True
        Dim cyka As Byte
        Dim blyat As Byte
        If CheckBox1.Checked = True Then
            Randomize()
            cyka = (Rnd() * 3) + 1
            If cyka = 1 Then
                PictureBox3.Image = My.Resources.woman
            End If
            If cyka = 2 Then
                PictureBox3.Image = My.Resources.woman1
            End If
            If cyka = 3 Then
                PictureBox3.Image = My.Resources.woman2
            End If
            If cyka = 4 Then
                PictureBox3.Image = My.Resources.woman3
            End If
        ElseIf CheckBox2.Checked = True Then
            Randomize()
            blyat = (Rnd() * 3) + 1
            If blyat = 1 Then
                PictureBox3.Image = My.Resources.jim
            End If
            If blyat = 2 Then
                PictureBox3.Image = My.Resources.kuriakos
            End If
            If blyat = 3 Then
                PictureBox3.Image = My.Resources.Mitsotakis
            End If
            If blyat = 4 Then
                PictureBox3.Image = My.Resources.mrbean
            End If
        End If
        My.Computer.Audio.Stop()
        My.Computer.Audio.Play(My.Resources.walk, AudioPlayMode.Background)

    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Console.Beep(500, 50)
        Panel3.Visible = False
        Button8.Visible = False
        Label9.Visible = False
        PictureBox3.Visible = False
        Label5.Visible = False
        Panel2.Visible = False
        Panel1.Visible = True
        Label8.Visible = False
        TextBox1.Text = ""
        Label10.Visible = False
        CheckBox2.Checked = False
        CheckBox1.Checked = False
        My.Computer.Audio.Stop()
        My.Computer.Audio.Play(My.Resources.Song1, AudioPlayMode.Background)
    End Sub


End Class

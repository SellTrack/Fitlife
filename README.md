<svg fill="none" viewBox="0 0 600 300" width="600" height="300" xmlns="http://www.w3.org/2000/svg">
  <foreignObject width="100%" height="100%">
    <div xmlns="http://www.w3.org/1999/xhtml">
      <style>
        @keyframes hi  {
            0% { transform: rotate( 0.0deg) }
           10% { transform: rotate(14.0deg) }
           20% { transform: rotate(-8.0deg) }
           30% { transform: rotate(14.0deg) }
           40% { transform: rotate(-4.0deg) }
           50% { transform: rotate(10.0deg) }
           60% { transform: rotate( 0.0deg) }
          100% { transform: rotate( 0.0deg) }
        }

        .container {
          background-color: black;

          width: 100%;
          height: 300px;

          display: flex;
          justify-content: center;
          align-items: center;
          color: white;

          font-family: -apple-system, BlinkMacSystemFont, "Segoe UI", Roboto, Helvetica, Arial, sans-serif, "Apple Color Emoji", "Segoe UI Emoji", "Segoe UI Symbol";
        }

        .hi {
          animation: hi 1.5s linear -0.5s infinite;
          display: inline-block;
          transform-origin: 70% 70%;
        }

        @media (prefers-reduced-motion) {
          .hi {
            animation: none;
          }
        }
      </style>

      <div class="container">
        <h1>Hi there, my name is Selman <div class="hi">👋</div></h1>
      </div>
    </div>
  </foreignObject>
</svg>

 # :question: What is this project
 This is fitness coach website project for my university developed with my friend Emre Yılmaz.

 # :question: Which language and libraries used for this project
 This project developed using .NET, Azure SQL, C#, and various nuget packages.

 # :question: What is required for run the website
 azure data studio to view the database

 # :question: How to run the game
 Simply drag the RPS file to vs code and run the tkm_game.java file

 # :video_game: About game
 This game takes your normal rock, paper and scissors game and takes a bit further. each item has his own health to live, power to damage, level to strenghten and xp to level up. each item deal and take damage by relying on calssic rps (rock,paper,scissors) rule. 

 ## :video_game: Game modes
 There is two way to play this game. 
 * Player vs. Computer
 * Computer vs. Computer

 ### :video_game: Player vs. Computer


[![image1](https://github.com/SellTrack/RPS/blob/main/RPS/sprites/readmeimage2.jpg?raw=true)](https://github.com/SellTrack/RPS/blob/main/RPS/sprites/readmeimage2.jpg?raw=true)


 You will need to select rock, paper or scissors 5 times. This game has round based system, so you will need to select one of your items for the round and opponent selects his owns.

 Each item deal and take damage themselves. Next round is no different. As round goes items hp will be deplate and not usable due to damages it took. The card which deal the last damage and eliminates his opponents item, will gain xp. 2 elimination will cause level up for that item and starts to deal damage even more . Game goes like this untill round limit. who has the most hp sum of all of his items wins the game.

[![image2](https://github.com/SellTrack/RPS/blob/main/RPS/sprites/readmeimage1.jpg?raw=true)](https://github.com/SellTrack/RPS/blob/main/RPS/sprites/readmeimage1.jpg?raw=true)



  :sparkles: You select your name and round limit

  :sparkles: You can select up to 3 from same item
 
  :exclamation: You need to select at least one from each item

  ### :video_game: Computer vs. Computer
  In this game mode, 2 sides selects item and plays. You will be just watching it. There is no round limit so one side must loose all of his items.
 
  Next round button starts a new round, finish button exits game before it finishes.

   :exclamation: There is quite a possible chance that game will lock and be in endless loop. Use finish button to exit the loop.


 # :sparkles: What i learned from this
 I learned classes, structers, image viewing and moving my algorithm knowledge more further.

 :white_check_mark: Making gui in java

 :white_check_mark: image showcase

 :white_check_mark: classes in java


 # CS50 Final Project - ParticleBrawl
Youtube-https://youtu.be/Gj3G3bIuXV8

Particle Brawl  is 2D Multidirectional shooters game with random spawning of attacking enemies and focus on particle systems.
This Game was made in Unity.

This game has player which can move and shoots in 4 directions with random spawning of enemies.This game keep tracks of your kill count and when your kill account equals to 100 you win the game.But if you die before your kill counts is 100,your kill count does not go down to 0 and you will start from where you last die.For example-if you die when your kills is 12,then you start from 12 kills not 0.When you reach 100 kills, window  appears and show the message "you win" with total no. of attempts you need to reach 100 kills.

A player has simple walk animation and a gun which can shoots in any direction.Your player Contain Health Bar at the top of screen Which will decrease when you hit by enemy.And increase when you kill the enemy.A player has statemachine of its own which has 6 states:-playerbasestate,playeridlestate,playermoveupstate,playermovedownstate,playermoveleftstate,playermoverightstate.
This game contains enemy which contains these logics:-
 * Enemy will attack player from certain distance. 
 * Move towards player if distance is greater than stopping distance.
 * Move away from player if distance is shorter than retreat distance.
 * Enemy have certain health.
 * They will attack you 1-2 seconds break. 
 
Each enemy is randomly different in attack speed,distance from player,moving speed towards player,enemy health.

When enemy dies it has some death particle effect.And When player dies,there is also death effect and slow motion time effect.when you die music will not restart again.

This Game  has powerups that will randomly instantiated b/w 7-12 seconds at the top and  fall downwards towards ground and destroy when it collide with ground.Each powerups has different abilities.

This game uses high amount of particle systems in every aspect of game.

* I think  this project satisfies the distinctiveness and complexity requirements for final project.

## Whats in the Game
* Player can move in 4 direction in a 2d world.
* player has gun which he shoots multidirectional.
* Background has infinite moving Particle system for visuals.
* There is Health Bar which shown your health and decrease when you hit  by enemy.
* when player kills the enemy  he gain some health(not exceeding the basic health) and kills count increase by 1.
* Each enemy is randomly different.For ex-attack speed,distance from player,moving speed towards player,enemy health.
* Enemy is spawning randomly after 5-10 seconds.
*Each enemy is randomly different in attack speed,distance from player,moving speed towards player,enemy health.
*Enemy spawns randomly at screen after 5-10 seconds.Enemy spawning is depend on killcount if - 
 *kill count>10 then 2 enemy spawning at the same time.
 *kill count>20 then 3 enemy spawning at the same time.
 *kill count>30 then 4 enemy spawning at the same time.
 *kill count>40 then 5 enemy spawning at the same time.
 *kill count>50 then 6 enemy spawning at the same time.
 *kill count>60 then 7 enemy spawning at the same time.
 *kill count>70 then 8 enemy spawning at the same time.
 *kill count>80 then 9 enemy spawning at the same time.
 *kill count>90 then 10 enemy spawning at the same time.
* when player dies death particle effect  and slow motion effect shown.
* when player dies ,gameover window appears and ask you to restart the game and when you restart your kills are shown which was previously before you die and music was not restart again.
* Music will destroy when you win.
* if killcount==10 then window appears and shown you win message with total no. of your attempts.
* There is 3 powerups in the game which was randomly instantiated b/w 7-12 seconds at the top and move downwards towards ground if it collide with ground it will destroy.
   * health powerup=your power get full when you collide with it.
   * slow powerup=This will decrease the speed of player.
   * fast powerup=This will increase the speed of player.  
* Game has three scenes.
   * Titlescene
   *  PlayScene
   * Winscene
* And Particle effect are shown in
   * when enemy hit or dies
   * when powerup collide
   * when enemy shoot bullet and goes to its target lacation
   * when player dies
   *all background in 3 scenes.

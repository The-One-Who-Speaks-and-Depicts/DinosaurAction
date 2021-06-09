using System;
using System.Collections.Generic;
using Xunit;
using DinosaurQuest.GameFunctions;
using DinosaurQuest.Creatures;
using DinosaurQuest.Territories;

namespace DinosaurQuestTests
{
    public class TerritoryTests
    {
    	[Fact]
        public void movementOutOfPositiveBounds_accessNotGranted_False()
        {
        	var mockCharacter = new Character();
            var mockTile = new MockTerritory(mockCharacter, 3, 3, 3, 3);

            var movement = mockCharacter.Move(mockTile, ICreature.direction.N);

            Assert.True(mockTile.X == movement.X);
            Assert.True(mockTile.Y == movement.Y);
        }

        [Fact]
        public void movementOutOfNegativeBounds_accessNotGranted_False()
        {
            var mockCharacter = new Character();
            var mockTile = new MockTerritory(mockCharacter, 3, 3, 1, 1);

            var movement = mockCharacter.Move(mockTile, ICreature.direction.S);

            Assert.True(mockTile.X == movement.X);
            Assert.True(mockTile.Y == movement.Y);
        }

        [Fact]
        public void movementWithinPositiveBoundsNorthwards_accessGranted_True()
        {
            var mockCharacter = new Character();
            var mockTile = new MockTerritory(mockCharacter, 3, 3, 2, 2);

            var movement = mockCharacter.Move(mockTile, ICreature.direction.NW);

            Assert.True(movement.X != mockTile.X || movement.Y != mockTile.Y);
        }

        [Fact]
        public void movementWithPack_packMoved_True()
        {
            var mockCharacter = new Character();
            var mockAnchiornis = new Anchiornis();
            mockCharacter.addToPack(mockAnchiornis);
            var mockTile = new MockTerritory(mockCharacter, 3, 3, 2, 2);
            mockTile.creatures = new List<ICreature>() {mockCharacter, mockAnchiornis};

            var movement = mockCharacter.Move(mockTile, ICreature.direction.N);
            bool packMoved = movement.creatures.Contains(mockAnchiornis) ? true : false;

            Assert.True(packMoved);
        }

        [Fact]
        public void enemyMoving_enemyMoved_True()
        {
            var mockCharacter = new Character();
            var mockAnchiornis = new Anchiornis();
            var mockTile = new MockTerritory(mockCharacter, 3, 3, 2, 2);
            mockTile.creatures = new List<ICreature>() {mockCharacter, mockAnchiornis};

            var movement = mockCharacter.Move(mockTile, ICreature.direction.N);
            mockAnchiornis.Move(mockTile, movement, true);
            bool enemyMoved = movement.creatures.Contains(mockAnchiornis) ? true : false;

            Assert.True(enemyMoved);
        }

        [Fact]
        public void enemyMoving_enemyFailed_False()
        {
            var mockCharacter = new Character();
            var mockAnchiornis = new Anchiornis();
            var mockTile = new MockTerritory(mockCharacter, 3, 3, 2, 2);
            mockTile.creatures = new List<ICreature>() {mockCharacter, mockAnchiornis};

            var movement = mockCharacter.Move(mockTile, ICreature.direction.N);
            mockAnchiornis.Move(mockTile, movement, false);
            bool enemyMoved = movement.creatures.Contains(mockAnchiornis) ? true : false;

            Assert.False(enemyMoved);
        }

        [Fact]
        public void PackMovingFromEnemy_enemyFailedPackMoved_False()
        {

            var mockCharacter = new Character();
            var mockAnchiornis = new Anchiornis();
            var enemyAnchiornis = new Anchiornis();
            mockCharacter.addToPack(mockAnchiornis);
            var mockTile = new MockTerritory(mockCharacter, 3, 3, 2, 2);
            mockTile.creatures = new List<ICreature>() {mockCharacter, mockAnchiornis, enemyAnchiornis};

            var movement = mockCharacter.Move(mockTile, ICreature.direction.N);
            enemyAnchiornis.Move(mockTile, movement, false);
            bool packMoved = movement.creatures.Contains(mockAnchiornis) ? true : false;
            bool enemyMoved = movement.creatures.Contains(enemyAnchiornis) ? true : false;

            Assert.True(packMoved);
            Assert.False(enemyMoved);
        }
    }
}

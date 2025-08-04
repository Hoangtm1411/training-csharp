using Basic_CSharp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Relationship
{
	public Character Target { get; }
	public float Affinity { get; set; }  // affected by Charisma
}

class RelationshipSystem
{
	private List<Relationship> relations;
	public void UpdateRelation(Character target, float amount) {}
}


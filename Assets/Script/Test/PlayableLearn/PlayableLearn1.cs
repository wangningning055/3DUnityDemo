using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;
using UnityEngine.Playables;
public class PlayableLearn1:MonoBehaviour
{
	public Animator animator;
	public List<AnimationClip> animations;
	PlayableGraph graph;
	AnimationMixerPlayable mixer;
	[Range(0, 1)] public float mixerNum = 0;
	void Start()
	{
		// CreatSingle creatSingle = new CreatSingle(animator, animations[0]);
		CreatMixer();
		graph.Play();
	}
	void Update()
	{
		mixer.SetInputWeight(1,  1 - mixerNum);
		mixer.SetInputWeight(0, mixerNum);
		if(Input.GetKeyDown(KeyCode.A))
		{
		}
		if(Input.GetKeyDown(KeyCode.S))
		{
			
		}
	}

	void CreatMixer()
	{
		graph = PlayableGraph.Create("player");
		graph.SetTimeUpdateMode(DirectorUpdateMode.GameTime);
		AnimationClipPlayable clip1 = AnimationClipPlayable.Create(graph, animations[0]);
		AnimationClipPlayable clip2 = AnimationClipPlayable.Create(graph, animations[1]);

		mixer = AnimationMixerPlayable.Create(graph, 2);

		AnimationPlayableOutput output = AnimationPlayableOutput.Create(graph, "out", animator);

		graph.Connect(clip1, 0,mixer, 0);
		graph.Connect(clip2, 0,mixer, 1);
		output.SetSourcePlayable(mixer);

	}
}

public class CreatSingle
{
	Animator _animator;
	AnimationClip _animation;
	public CreatSingle(Animator animator, AnimationClip animation)
	{
		_animator = animator; 
		_animation = animation;
	}
	public PlayableGraph CreatSingle1()
	{
		PlayableGraph graph = PlayableGraph.Create("singleGraph");
		graph.SetTimeUpdateMode(DirectorUpdateMode.GameTime);
		AnimationPlayableOutput _output = AnimationPlayableOutput.Create(graph, "anim_outPut", _animator);
		AnimationClipPlayable _clip = AnimationClipPlayable.Create(graph, _animation);
		_clip.SetSpeed(5f);
		_output.SetSourcePlayable(_clip);
		
		return graph;
	}
}
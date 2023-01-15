<?php

namespace App\Controller;

use Symfony\Bundle\FrameworkBundle\Controller\AbstractController;
use Symfony\Component\HttpFoundation\Response;
use Symfony\Component\Routing\Annotation\Route;

class Wish extends AbstractController
{
    /**
     * @Route("wish_show/{id}", name="wish_show")
     * @param $id
     * @return Response
     */
    public function show($id)
    {
        $wish = array('id' => 1, 'title' => "A database for this system!", 'description' => "How do you make a system without a database dude?", 'upvotes' => 5, 'downvotes' => 1);

        return $this->render("wishes/view.html.twig", [
            'wish' => $wish
        ]);
    }

    /**
     * @Route("new_wish", name="new_wish")
     * @return Response
     */
    public function new()
    {


        return $this->render("wishes/newWish.html.twig");
    }
}